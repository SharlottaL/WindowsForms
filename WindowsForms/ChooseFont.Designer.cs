namespace WindowsForms
{
    partial class ChooseFont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFont));
            this.lblChooseFont = new System.Windows.Forms.Label();
            this.comboBoxChooseFont = new System.Windows.Forms.ComboBox();
            this.lblExampl = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseFont
            // 
            this.lblChooseFont.AutoSize = true;
            this.lblChooseFont.Location = new System.Drawing.Point(13, 13);
            this.lblChooseFont.Name = "lblChooseFont";
            this.lblChooseFont.Size = new System.Drawing.Size(93, 13);
            this.lblChooseFont.TabIndex = 0;
            this.lblChooseFont.Text = "Выберите шрифт";
            // 
            // comboBoxChooseFont
            // 
            this.comboBoxChooseFont.FormattingEnabled = true;
            this.comboBoxChooseFont.Location = new System.Drawing.Point(16, 30);
            this.comboBoxChooseFont.Name = "comboBoxChooseFont";
            this.comboBoxChooseFont.Size = new System.Drawing.Size(670, 21);
            this.comboBoxChooseFont.TabIndex = 1;
            this.comboBoxChooseFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseFont_SelectedIndexChanged);
            // 
            // lblExampl
            // 
            this.lblExampl.AutoSize = true;
            this.lblExampl.Font = new System.Drawing.Font("MV Boli", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExampl.Location = new System.Drawing.Point(22, 218);
            this.lblExampl.Name = "lblExampl";
            this.lblExampl.Size = new System.Drawing.Size(170, 55);
            this.lblExampl.TabIndex = 2;
            this.lblExampl.Text = "Exampl";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 72);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "FileName:";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(692, 31);
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(96, 20);
            this.nudFontSize.TabIndex = 4;
            this.nudFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(611, 404);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(692, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ChooseFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblExampl);
            this.Controls.Add(this.comboBoxChooseFont);
            this.Controls.Add(this.lblChooseFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseFont";
            this.ShowInTaskbar = false;
            this.Text = "ChooseFont";
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFont;
        private System.Windows.Forms.ComboBox comboBoxChooseFont;
        private System.Windows.Forms.Label lblExampl;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}