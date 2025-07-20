using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCurrentTime1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CurrentData.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datetimepicker?view=windowsdesktop-9.0#:~:text=%22MMMM%20dd%2C%20yyyy%20%2D%20dddd%22
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            labelCurrentDay.Text = DateTime.Now.ToString("dddd");
            //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datetimepicker?view=windowsdesktop-9.0#:~:text=%22MMMM%20dd%2C%20yyyy%20%2D%20dddd%22
        }
    }
}
