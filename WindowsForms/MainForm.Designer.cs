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
            this.labelCurrentTime1 = new System.Windows.Forms.Label();
            this.CurrentData = new System.Windows.Forms.Label();
            this.labelCurrentDay = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCurrentTime1
            // 
            this.labelCurrentTime1.AutoSize = true;
            this.labelCurrentTime1.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime1.Location = new System.Drawing.Point(19, 9);
            this.labelCurrentTime1.Name = "labelCurrentTime1";
            this.labelCurrentTime1.Size = new System.Drawing.Size(264, 58);
            this.labelCurrentTime1.TabIndex = 0;
            this.labelCurrentTime1.Text = "CurrentTime";
            // 
            // CurrentData
            // 
            this.CurrentData.AutoSize = true;
            this.CurrentData.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentData.Location = new System.Drawing.Point(19, 86);
            this.CurrentData.Name = "CurrentData";
            this.CurrentData.Size = new System.Drawing.Size(266, 58);
            this.CurrentData.TabIndex = 1;
            this.CurrentData.Text = "CurrentData";
            // 
            // labelCurrentDay
            // 
            this.labelCurrentDay.AutoSize = true;
            this.labelCurrentDay.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDay.Location = new System.Drawing.Point(19, 163);
            this.labelCurrentDay.Name = "labelCurrentDay";
            this.labelCurrentDay.Size = new System.Drawing.Size(253, 58);
            this.labelCurrentDay.TabIndex = 2;
            this.labelCurrentDay.Text = "CurrentDay";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(249, 138);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(239, 38);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Показать дату";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox4.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(249, 224);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(355, 38);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Показать день недели";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(793, 486);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.labelCurrentDay);
            this.Controls.Add(this.CurrentData);
            this.Controls.Add(this.labelCurrentTime1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentTime1;
        private System.Windows.Forms.Label CurrentData;
        private System.Windows.Forms.Label labelCurrentDay;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

