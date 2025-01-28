namespace StudentGradesManager
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnShowGrade = new System.Windows.Forms.Button();
            this.btnCalculateAvg = new System.Windows.Forms.Button();
            this.lb1stGrades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(68, 66);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(95, 16);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(115, 124);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 16);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(202, 60);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(202, 118);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 22);
            this.txtGrade.TabIndex = 3;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(67, 195);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(96, 23);
            this.btnAddGrade.TabIndex = 4;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // btnShowGrade
            // 
            this.btnShowGrade.Location = new System.Drawing.Point(202, 195);
            this.btnShowGrade.Name = "btnShowGrade";
            this.btnShowGrade.Size = new System.Drawing.Size(117, 23);
            this.btnShowGrade.TabIndex = 5;
            this.btnShowGrade.Text = "Show All Grades";
            this.btnShowGrade.UseVisualStyleBackColor = true;
            this.btnShowGrade.Click += new System.EventHandler(this.btnShowGrade_Click);
            // 
            // btnCalculateAvg
            // 
            this.btnCalculateAvg.Location = new System.Drawing.Point(352, 195);
            this.btnCalculateAvg.Name = "btnCalculateAvg";
            this.btnCalculateAvg.Size = new System.Drawing.Size(127, 23);
            this.btnCalculateAvg.TabIndex = 6;
            this.btnCalculateAvg.Text = "Calculate Average";
            this.btnCalculateAvg.UseVisualStyleBackColor = true;
            this.btnCalculateAvg.Click += new System.EventHandler(this.btnCalculateAvg_Click);
            // 
            // lb1stGrades
            // 
            this.lb1stGrades.FormattingEnabled = true;
            this.lb1stGrades.ItemHeight = 16;
            this.lb1stGrades.Location = new System.Drawing.Point(359, 56);
            this.lb1stGrades.Name = "lb1stGrades";
            this.lb1stGrades.Size = new System.Drawing.Size(120, 84);
            this.lb1stGrades.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 347);
            this.Controls.Add(this.lb1stGrades);
            this.Controls.Add(this.btnCalculateAvg);
            this.Controls.Add(this.btnShowGrade);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblStudentName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnShowGrade;
        private System.Windows.Forms.Button btnCalculateAvg;
        private System.Windows.Forms.ListBox lb1stGrades;
    }
}

