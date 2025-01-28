namespace Invoice_Total
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt4 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.GradientActiveCaption;
            lbl1.Location = new Point(195, 52);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(68, 20);
            lbl1.TabIndex = 4;
            lbl1.Text = "Subtotal:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.GradientActiveCaption;
            lbl2.Location = new Point(141, 92);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(122, 20);
            lbl2.TabIndex = 5;
            lbl2.Text = "Discount Percent:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = SystemColors.GradientActiveCaption;
            lbl3.Location = new Point(136, 141);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(127, 20);
            lbl3.TabIndex = 6;
            lbl3.Text = "Discount Amount:";
            lbl3.Click += label3_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = SystemColors.GradientActiveCaption;
            lbl4.Location = new Point(218, 182);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 20);
            lbl4.TabIndex = 7;
            lbl4.Text = "Total:";
            // 
            // txt1
            // 
            txt1.Location = new Point(285, 49);
            txt1.Name = "txt1";
            txt1.Size = new Size(379, 27);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(285, 89);
            txt2.Name = "txt2";
            txt2.ReadOnly = true;
            txt2.Size = new Size(379, 27);
            txt2.TabIndex = 8;
            // 
            // txt3
            // 
            txt3.Location = new Point(285, 134);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(379, 27);
            txt3.TabIndex = 9;
            // 
            // txt4
            // 
            txt4.Location = new Point(285, 175);
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(379, 27);
            txt4.TabIndex = 10;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightGray;
            btn1.Location = new Point(164, 266);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 4;
            btn1.Text = "&Calculate";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightGray;
            btn2.Location = new Point(364, 266);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 4;
            btn2.Text = "C&lear";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightGray;
            btn3.Location = new Point(570, 266);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 1;
            btn3.Text = "&Exit";
            btn3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AcceptButton = btn1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}
