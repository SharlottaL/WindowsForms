using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        ChooseFont chooseFont;
        ColorDialog cdBackColor;
        ColorDialog cdForeColor;
        public MainForm()
        {
            InitializeComponent();
            ShowControls(cmShowControl.Checked);
            ShowConsole(cmDebugConsole.Checked = true);
            chooseFont = new ChooseFont();
            cdBackColor = new ColorDialog();
            cdForeColor = new ColorDialog();
            this.Location = new Point
                (
                    Screen.PrimaryScreen.Bounds.Width - this.Width,
                    100
                );
            chooseFont.StartPosition = FormStartPosition.Manual;
            chooseFont.Location = new Point
                (
                    this.Location.X - chooseFont.Width,
                    100
                );
            LoadSettings();
        }

        void ShowControls(bool visible)
        {
            cbShowDateCurrent.Visible = visible;
            cbShowWeekDayCurrent.Visible = visible;
            buttonHideControls.Visible = visible;
            this.ShowInTaskbar = visible;
            this.TransparencyKey = visible ? Color.Empty : this.BackColor;
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
            this.labelTime.BackColor = visible ? this.BackColor : Color.DeepSkyBlue;
        }
        void ShowConsole(bool visible)
        {
            if (visible)
                AllocConsole();
            else
                FreeConsole();
        }
        void SaveSettings()
        {
            StreamWriter settings = new StreamWriter("Settings.ini");

            settings.WriteLine($"{this.Location.X}x{this.Location.Y}");
            settings.WriteLine(cmETopmost.Checked);     
            settings.WriteLine(cmShowControl.Checked); 
            settings.WriteLine(cmDebugConsole.Checked); 
            settings.WriteLine(cmShowDateCurrent.Checked);    
            settings.WriteLine(cmShowDayWeek.Checked);  
            settings.WriteLine(cmLoadOnWindowsStartup.Checked);
            settings.WriteLine(cdBackColor.Color.ToArgb()); 
            settings.WriteLine(cdForeColor.Color.ToArgb());
            settings.WriteLine(chooseFont.Filename);   
            settings.Close();
        }
        void LoadSettings()
        {
            StreamReader settings = new StreamReader("Settings.ini");
            string location = settings.ReadLine();  
            this.Location = new Point
                (
                    Convert.ToInt32(location.Split('x').First()),
                    Convert.ToInt32(location.Split('x').Last())
                );

            cmETopmost.Checked = bool.Parse(settings.ReadLine());       
            cmShowControl.Checked = bool.Parse(settings.ReadLine());  
            cmDebugConsole.Checked = bool.Parse(settings.ReadLine());  
            cmShowDateCurrent.Checked = bool.Parse(settings.ReadLine());     
            cmShowDayWeek.Checked = bool.Parse(settings.ReadLine());    
            cmLoadOnWindowsStartup.Checked = bool.Parse(settings.ReadLine());
            cdBackColor.Color = labelTime.BackColor = Color.FromArgb(Convert.ToInt32(settings.ReadLine()));
            cdForeColor.Color = labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(settings.ReadLine()));
            string font_name = settings.ReadLine();                   
            chooseFont = new ChooseFont(this, font_name, 32);
            labelTime.Font = chooseFont.Font;
            settings.Close();
        }
        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    labelCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDateCurrent.Checked)
                labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            if (cbShowWeekDayCurrent.Checked)
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            notifyIcon1.Text = labelTime.Text;
       
        }

        private void buttonHideControls_Click(object sender, EventArgs e)
        {
            ShowControls(cmShowControl.Checked = false);
        }
        private void labelTime_DoubleClick(object sender, EventArgs e)
        {
            ShowControls(cmShowControl.Checked = true);
        }
        private void cmClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cmETopmost.Checked;
        }

        private void cmShowControl_CheckedChanged(object sender, EventArgs e)
        {
            ShowControls(cmShowControl.Checked);
        }
        ////////////////////////////////////////////////////////////////////////////
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

       
        private void cmDebugConsole_DoubleClick(object sender, EventArgs e)
        {
            ShowConsole(cmDebugConsole.Checked);
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.TopMost) return;
            this.TopMost = true;
            this.TopMost = false;
        }

        private void cmShowDateCurrent_CheckedChanged(object sender, EventArgs e)
        {
            cbShowDateCurrent.Checked = cmShowDateCurrent.Checked;
        }

        private void cmShowDayWeek_CheckedChanged(object sender, EventArgs e)
        {
            cbShowWeekDayCurrent.Checked = cmShowDayWeek.Checked;
        }

        private void cmBackgroundColor_Click(object sender, EventArgs e)
        {
            cdBackColor.ShowDialog();
            labelTime.BackColor = cdBackColor.Color;
            
        
        }

        private void cmForegroundColor_Click(object sender, EventArgs e)
        {
            cdForeColor.ShowDialog();
            labelTime.ForeColor = cdForeColor.Color;
        }

        private void cmFonts_Click(object sender, EventArgs e)
        {
            chooseFont.Location = new Point
                (
                this.Location.X - chooseFont.Width - 25,
                this.Location.Y
                );
            chooseFont.ShowDialog();
            labelTime.Font = chooseFont.Font;
        }

        private void labelTime_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void cmLoadOnWindowsStartup_CheckedChanged(object sender, EventArgs e)
        {
            string key_name = "Clock_PD_411";
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);  
            if (cmLoadOnWindowsStartup.Checked) key.SetValue(key_name, Application.ExecutablePath);
            else key.DeleteValue(key_name, false);  
            key.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
