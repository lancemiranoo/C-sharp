namespace MyInvestmentCalculatorProject
{
    partial class Form1
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
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.RDB1 = new System.Windows.Forms.RadioButton();
            this.RDB2 = new System.Windows.Forms.RadioButton();
            this.LBLmonthly = new System.Windows.Forms.Label();
            this.LBLyearly = new System.Windows.Forms.Label();
            this.LBLyears = new System.Windows.Forms.Label();
            this.LBLvalue = new System.Windows.Forms.Label();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.TXT3 = new System.Windows.Forms.TextBox();
            this.TXT4 = new System.Windows.Forms.TextBox();
            this.GB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.RDB2);
            this.GB1.Controls.Add(this.RDB1);
            this.GB1.Location = new System.Drawing.Point(153, 49);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(482, 71);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Calculate";
            // 
            // RDB1
            // 
            this.RDB1.AutoSize = true;
            this.RDB1.Location = new System.Drawing.Point(67, 37);
            this.RDB1.Name = "RDB1";
            this.RDB1.Size = new System.Drawing.Size(101, 20);
            this.RDB1.TabIndex = 1;
            this.RDB1.TabStop = true;
            this.RDB1.Text = "Future value";
            this.RDB1.UseVisualStyleBackColor = true;
            this.RDB1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RDB2
            // 
            this.RDB2.AutoSize = true;
            this.RDB2.Location = new System.Drawing.Point(239, 37);
            this.RDB2.Name = "RDB2";
            this.RDB2.Size = new System.Drawing.Size(148, 20);
            this.RDB2.TabIndex = 0;
            this.RDB2.TabStop = true;
            this.RDB2.Text = "Monthly Investments";
            this.RDB2.UseVisualStyleBackColor = true;
            this.RDB2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LBLmonthly
            // 
            this.LBLmonthly.AutoSize = true;
            this.LBLmonthly.Location = new System.Drawing.Point(217, 155);
            this.LBLmonthly.Name = "LBLmonthly";
            this.LBLmonthly.Size = new System.Drawing.Size(123, 16);
            this.LBLmonthly.TabIndex = 1;
            this.LBLmonthly.Text = "Monthly Investment:";
            // 
            // LBLyearly
            // 
            this.LBLyearly.AutoSize = true;
            this.LBLyearly.Location = new System.Drawing.Point(217, 189);
            this.LBLyearly.Name = "LBLyearly";
            this.LBLyearly.Size = new System.Drawing.Size(142, 16);
            this.LBLyearly.TabIndex = 2;
            this.LBLyearly.Text = "Yearly investment rate:";
            // 
            // LBLyears
            // 
            this.LBLyears.AutoSize = true;
            this.LBLyears.Location = new System.Drawing.Point(217, 223);
            this.LBLyears.Name = "LBLyears";
            this.LBLyears.Size = new System.Drawing.Size(109, 16);
            this.LBLyears.TabIndex = 3;
            this.LBLyears.Text = "Number of years:";
            this.LBLyears.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBLvalue
            // 
            this.LBLvalue.AutoSize = true;
            this.LBLvalue.Location = new System.Drawing.Point(217, 255);
            this.LBLvalue.Name = "LBLvalue";
            this.LBLvalue.Size = new System.Drawing.Size(83, 16);
            this.LBLvalue.TabIndex = 4;
            this.LBLvalue.Text = "Future value:";
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(346, 294);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(75, 23);
            this.BTN1.TabIndex = 5;
            this.BTN1.Text = "Calculate";
            this.BTN1.UseVisualStyleBackColor = true;
            // 
            // BTN2
            // 
            this.BTN2.Location = new System.Drawing.Point(465, 294);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(75, 23);
            this.BTN2.TabIndex = 6;
            this.BTN2.Text = "Exit";
            this.BTN2.UseVisualStyleBackColor = true;
            // 
            // TXT1
            // 
            this.TXT1.Location = new System.Drawing.Point(392, 149);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(148, 22);
            this.TXT1.TabIndex = 7;
            // 
            // TXT2
            // 
            this.TXT2.Location = new System.Drawing.Point(392, 182);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(148, 22);
            this.TXT2.TabIndex = 8;
            // 
            // TXT3
            // 
            this.TXT3.Location = new System.Drawing.Point(392, 216);
            this.TXT3.Name = "TXT3";
            this.TXT3.Size = new System.Drawing.Size(148, 22);
            this.TXT3.TabIndex = 9;
            // 
            // TXT4
            // 
            this.TXT4.Location = new System.Drawing.Point(392, 248);
            this.TXT4.Name = "TXT4";
            this.TXT4.Size = new System.Drawing.Size(148, 22);
            this.TXT4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXT4);
            this.Controls.Add(this.TXT3);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.LBLvalue);
            this.Controls.Add(this.LBLyears);
            this.Controls.Add(this.LBLyearly);
            this.Controls.Add(this.LBLmonthly);
            this.Controls.Add(this.GB1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB1.ResumeLayout(false);
            this.GB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.RadioButton RDB1;
        private System.Windows.Forms.RadioButton RDB2;
        private System.Windows.Forms.Label LBLmonthly;
        private System.Windows.Forms.Label LBLyearly;
        private System.Windows.Forms.Label LBLyears;
        private System.Windows.Forms.Label LBLvalue;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.TextBox TXT3;
        private System.Windows.Forms.TextBox TXT4;
        public System.Windows.Forms.Button BTN1;
    }
}

