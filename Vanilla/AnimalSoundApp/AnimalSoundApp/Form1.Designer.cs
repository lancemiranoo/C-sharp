namespace AnimalSoundApp
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
            this.cmbAnimals = new System.Windows.Forms.ComboBox();
            this.btnShowSound = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbAnimals
            // 
            this.cmbAnimals.FormattingEnabled = true;
            this.cmbAnimals.Location = new System.Drawing.Point(56, 60);
            this.cmbAnimals.Name = "cmbAnimals";
            this.cmbAnimals.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimals.TabIndex = 0;
            // 
            // btnShowSound
            // 
            this.btnShowSound.Location = new System.Drawing.Point(56, 111);
            this.btnShowSound.Name = "btnShowSound";
            this.btnShowSound.Size = new System.Drawing.Size(75, 23);
            this.btnShowSound.TabIndex = 1;
            this.btnShowSound.Text = "Show";
            this.btnShowSound.UseVisualStyleBackColor = true;
            this.btnShowSound.Click += new System.EventHandler(this.btnShowSound_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(201, 68);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(44, 16);
            this.lblSound.TabIndex = 2;
            this.lblSound.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 283);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.btnShowSound);
            this.Controls.Add(this.cmbAnimals);
            this.Name = "MainForm";
            this.Text = "Animal Sound App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnimals;
        private System.Windows.Forms.Button btnShowSound;
        private System.Windows.Forms.Label lblSound;
    }
}

