using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BankAccount bankAccount;
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve input values from textboxes.
            string accountNumber = txtAccountNumber.Text;   // Get the amount number
            string accountHolder = txtAccountHolder.Text;   // Get the account holder name
            double initialBalance = Convert.ToDouble(txtBalance.Text);  // Convert balance from text to number.

            // Step 2: Create a new BankAccount object using the input values.
            bankAccount = new BankAccount(accountNumber, accountHolder, initialBalance);

            // Step 3: Display account information in the multiline textbox.
            txtAccountInfo.Text = bankAccount.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (bankAccount != null) // Check if the account exists.
            {
                double amount = Convert.ToDouble(txtDepositAmount.Text);

                // Convert amount from text to number.
                bankAccount.Deposit(amount);    // Add money to the account.

                txtAccountInfo.Text = bankAccount.ToString();   // Update account information display.
            }
            else
            {
                MessageBox.Show("Create an account first.");    // Show a message if no account exists.
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (bankAccount != null) // Check if the account exist.
            {
                try
                {
                    double amount = Convert.ToDouble(txtWithdrawAmount.Text);   // Convert amount from text to number.
                    bankAccount.withdraw(amount);   // Remove money from the account.
                    txtAccountInfo.Text = bankAccount.ToString(); // Update account information display.
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);    // Show error if balance is insufficient.
                }
            }
            else
            {
                MessageBox.Show("Create an account first.");    // Show a message if no account exists.
            }
        }
    }
}

