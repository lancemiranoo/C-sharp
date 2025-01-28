namespace bankManager
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblOperations = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.Wi = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.txtAccountInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(96, 107);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(109, 16);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Location = new System.Drawing.Point(103, 151);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(102, 16);
            this.lblAccountHolder.TabIndex = 1;
            this.lblAccountHolder.Text = "Account Holder:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(112, 194);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(93, 16);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Initial Balance:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(256, 101);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.Location = new System.Drawing.Point(256, 145);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.Size = new System.Drawing.Size(100, 22);
            this.txtAccountHolder.TabIndex = 4;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(256, 188);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(226, 370);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(116, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Location = new System.Drawing.Point(376, 321);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(73, 16);
            this.lblOperations.TabIndex = 7;
            this.lblOperations.Text = "Operations";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(412, 107);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(105, 16);
            this.lblDeposit.TabIndex = 8;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // Wi
            // 
            this.Wi.AutoSize = true;
            this.Wi.Location = new System.Drawing.Point(404, 148);
            this.Wi.Name = "Wi";
            this.Wi.Size = new System.Drawing.Size(113, 16);
            this.Wi.TabIndex = 9;
            this.Wi.Text = "Withdraw Amount:";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(391, 204);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(126, 16);
            this.lblAccountInfo.TabIndex = 10;
            this.lblAccountInfo.Text = "Account Information:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(365, 370);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(471, 370);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 12;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(538, 107);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(192, 22);
            this.txtDepositAmount.TabIndex = 13;
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(538, 145);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(192, 22);
            this.txtWithdrawAmount.TabIndex = 14;
            // 
            // txtAccountInfo
            // 
            this.txtAccountInfo.Location = new System.Drawing.Point(538, 204);
            this.txtAccountInfo.Multiline = true;
            this.txtAccountInfo.Name = "txtAccountInfo";
            this.txtAccountInfo.Size = new System.Drawing.Size(192, 87);
            this.txtAccountInfo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAccountInfo);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.Wi);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccountHolder);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountHolder);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label Wi;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.TextBox txtAccountInfo;
    }
}

