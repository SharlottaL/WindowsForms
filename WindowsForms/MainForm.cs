using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

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
            //bool console = visible ? AllocConsole() : FreeConsole();
            //if(console)Console.WriteLine(console);
            if (visible)
                AllocConsole();
            else
                FreeConsole();
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
           // notifyIcon.Text = labelTime.Text;
            //if (cmDebugConsole.Checked)
            //    Console.WriteLine(notifyIcon.Text);
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
            this.TopMost = topToolStripMenuItem.Checked;
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
            labelTime.BackColor = cdBackColor.Color;                 //// if (cdBackColor.ShowDialog() == DialogResult.OK)
        }

        private void cmForegroundColor_Click(object sender, EventArgs e)
        {
            cdForeColor.ShowDialog();
            labelTime.ForeColor = cdForeColor.Color;
        }

        private void cmFonts_Click(object sender, EventArgs e)
        {
            chooseFont.ShowDialog();
            labelTime.Font = chooseFont.Font;
        }
    }
}
