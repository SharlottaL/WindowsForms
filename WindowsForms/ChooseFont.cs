using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WindowsForms
{
    public partial class ChooseFont : Form
    {
        public Font Font { get; set; }
        public ChooseFont()
        {
            InitializeComponent();
            comboBoxChooseFont.Items.AddRange(GetFontListFromCurrentDirectoryByExtension("*.ttf"));
            comboBoxChooseFont.Items.AddRange(GetFontListFromCurrentDirectoryByExtension("*.otf"));
           //1)
              comboBoxChooseFont.Sorted = true;
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.sorted?view=windowsdesktop-9.0#system-windows-forms-combobox-sorted:~:text=public%20bool%20Sorted,%D0%B1%D0%B0%D0%B7%D0%BE%D0%B2%D1%83%D1%8E%20%D0%BC%D0%BE%D0%B4%D0%B5%D0%BB%D1%8C%20%D0%B4%D0%B0%D0%BD%D0%BD%D1%8B%D1%85.
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox?view=windowsdesktop-9.0#:~:text=%D0%A1%D0%BE%D1%80%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%BE,%D0%B2%20%D1%80%D0%B0%D1%81%D0%BA%D1%80%D1%8B%D0%B2%D0%B0%D1%8E%D1%89%D0%B5%D0%BC%D1%81%D1%8F%20%D1%81%D0%BF%D0%B8%D1%81%D0%BA%D0%B5.
            comboBoxChooseFont.SelectedIndex = 0;
            
        }
        public string[] GetFontListFromCurrentDirectoryByExtension(string extension)
        {
            Console.WriteLine(Application.ExecutablePath);
            string execution_path = Path.GetDirectoryName(Application.ExecutablePath);
            Console.WriteLine(execution_path);
            Directory.SetCurrentDirectory($"{execution_path}\\..\\..\\Fonts");
            Console.WriteLine(Directory.GetCurrentDirectory());
            string[] fonts = Directory.GetFiles(Directory.GetCurrentDirectory(), extension);
            for (int i = 0; i < fonts.Length; i++)
            {
                fonts[i] = fonts[i].Split('\\').Last();
            }
            return fonts;
        }
        void SetFont(string filename, float size = 32)
        {

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(filename);
            lblExampl.Font = new Font(pfc.Families[0], size);
        }

        

        private void comboBoxChooseFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont((sender as ComboBox).SelectedItem.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Font = lblExampl.Font;
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            SetFont(comboBoxChooseFont.SelectedItem.ToString(), (float)nudFontSize.Value);
        }
    }
}
