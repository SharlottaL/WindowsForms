namespace WindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.cmMainMenuM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowControl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDebugConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowDateCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowDayWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmFonts = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmClos = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShowDateCurrent = new System.Windows.Forms.CheckBox();
            this.cbShowWeekDayCurrent = new System.Windows.Forms.CheckBox();
            this.buttonHideControls = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmMainMenuM.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.cmMainMenuM;
            this.labelTime.Font = new System.Drawing.Font("Script MT Bold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(32, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(276, 58);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Current Time";
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            this.labelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseDown);
            // 
            // cmMainMenuM
            // 
            this.cmMainMenuM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.cmShowControl,
            this.cmDebugConsole,
            this.toolStripSeparator2,
            this.cmShowDateCurrent,
            this.cmShowDayWeek,
            this.toolStripSeparator3,
            this.cmFonts,
            this.cmBackgroundColor,
            this.cmForegroundColor,
            this.toolStripSeparator4,
            this.cmClos});
            this.cmMainMenuM.Name = "cmMainMenuM";
            this.cmMainMenuM.Size = new System.Drawing.Size(169, 220);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.CheckOnClick = true;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.topToolStripMenuItem.Text = "Topmost";
            this.topToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topToolStripMenuItem_CheckedChanged);
            // 
            // cmShowControl
            // 
            this.cmShowControl.CheckOnClick = true;
            this.cmShowControl.Name = "cmShowControl";
            this.cmShowControl.Size = new System.Drawing.Size(168, 22);
            this.cmShowControl.Text = "Show controls";
            this.cmShowControl.CheckedChanged += new System.EventHandler(this.cmShowControl_CheckedChanged);
            // 
            // cmDebugConsole
            // 
            this.cmDebugConsole.CheckOnClick = true;
            this.cmDebugConsole.Name = "cmDebugConsole";
            this.cmDebugConsole.Size = new System.Drawing.Size(168, 22);
            this.cmDebugConsole.Text = "Console";
            this.cmDebugConsole.DoubleClick += new System.EventHandler(this.cmDebugConsole_DoubleClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // cmShowDateCurrent
            // 
            this.cmShowDateCurrent.CheckOnClick = true;
            this.cmShowDateCurrent.Name = "cmShowDateCurrent";
            this.cmShowDateCurrent.Size = new System.Drawing.Size(168, 22);
            this.cmShowDateCurrent.Text = "Show date";
            this.cmShowDateCurrent.CheckedChanged += new System.EventHandler(this.cmShowDateCurrent_CheckedChanged);
            // 
            // cmShowDayWeek
            // 
            this.cmShowDayWeek.CheckOnClick = true;
            this.cmShowDayWeek.Name = "cmShowDayWeek";
            this.cmShowDayWeek.Size = new System.Drawing.Size(168, 22);
            this.cmShowDayWeek.Text = "Show weekday";
            this.cmShowDayWeek.CheckedChanged += new System.EventHandler(this.cmShowDayWeek_CheckedChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // cmFonts
            // 
            this.cmFonts.Name = "cmFonts";
            this.cmFonts.Size = new System.Drawing.Size(168, 22);
            this.cmFonts.Text = "Font";
            this.cmFonts.Click += new System.EventHandler(this.cmFonts_Click);
            // 
            // cmBackgroundColor
            // 
            this.cmBackgroundColor.Name = "cmBackgroundColor";
            this.cmBackgroundColor.Size = new System.Drawing.Size(168, 22);
            this.cmBackgroundColor.Text = "Background color";
            this.cmBackgroundColor.Click += new System.EventHandler(this.cmBackgroundColor_Click);
            // 
            // cmForegroundColor
            // 
            this.cmForegroundColor.Name = "cmForegroundColor";
            this.cmForegroundColor.Size = new System.Drawing.Size(168, 22);
            this.cmForegroundColor.Text = "Foreground color";
            this.cmForegroundColor.Click += new System.EventHandler(this.cmForegroundColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // cmClos
            // 
            this.cmClos.Name = "cmClos";
            this.cmClos.Size = new System.Drawing.Size(168, 22);
            this.cmClos.Text = "Close";
            this.cmClos.Click += new System.EventHandler(this.cmClos_Click);
            // 
            // cbShowDateCurrent
            // 
            this.cbShowDateCurrent.AutoSize = true;
            this.cbShowDateCurrent.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowDateCurrent.Location = new System.Drawing.Point(313, 285);
            this.cbShowDateCurrent.Name = "cbShowDateCurrent";
            this.cbShowDateCurrent.Size = new System.Drawing.Size(231, 40);
            this.cbShowDateCurrent.TabIndex = 1;
            this.cbShowDateCurrent.Text = "Показать дату";
            this.cbShowDateCurrent.UseVisualStyleBackColor = true;
            // 
            // cbShowWeekDayCurrent
            // 
            this.cbShowWeekDayCurrent.AutoSize = true;
            this.cbShowWeekDayCurrent.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowWeekDayCurrent.Location = new System.Drawing.Point(203, 331);
            this.cbShowWeekDayCurrent.Name = "cbShowWeekDayCurrent";
            this.cbShowWeekDayCurrent.Size = new System.Drawing.Size(341, 40);
            this.cbShowWeekDayCurrent.TabIndex = 2;
            this.cbShowWeekDayCurrent.Text = "Показать день недели";
            this.cbShowWeekDayCurrent.UseVisualStyleBackColor = true;
            // 
            // buttonHideControls
            // 
            this.buttonHideControls.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHideControls.Location = new System.Drawing.Point(13, 318);
            this.buttonHideControls.Name = "buttonHideControls";
            this.buttonHideControls.Size = new System.Drawing.Size(135, 46);
            this.buttonHideControls.TabIndex = 3;
            this.buttonHideControls.Text = "Hide controls";
            this.buttonHideControls.UseVisualStyleBackColor = true;
            this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmMainMenuM;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(556, 383);
            this.Controls.Add(this.buttonHideControls);
            this.Controls.Add(this.cbShowWeekDayCurrent);
            this.Controls.Add(this.cbShowDateCurrent);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cloack PD_411";
            this.cmMainMenuM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip cmMainMenu;
        private System.Windows.Forms.ToolStripMenuItem cmTopmost;
        private System.Windows.Forms.ToolStripMenuItem cmShowDate;
        private System.Windows.Forms.ToolStripMenuItem cmShowWeekday;
        private System.Windows.Forms.ToolStripMenuItem cmShowControls;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmFont;
        private System.Windows.Forms.ToolStripMenuItem cmBackColor;
        private System.Windows.Forms.ToolStripMenuItem cmForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmClose;
        private System.Windows.Forms.ToolStripMenuItem cmConsole;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox cbShowDateCurrent;
        private System.Windows.Forms.CheckBox cbShowWeekDayCurrent;
        private System.Windows.Forms.Button buttonHideControls;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmMainMenuM;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmShowDateCurrent;
        private System.Windows.Forms.ToolStripMenuItem cmShowDayWeek;
        private System.Windows.Forms.ToolStripMenuItem cmShowControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmFonts;
        private System.Windows.Forms.ToolStripMenuItem cmBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem cmForegroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cmClos;
        private System.Windows.Forms.ToolStripMenuItem cmDebugConsole;
    }
}

