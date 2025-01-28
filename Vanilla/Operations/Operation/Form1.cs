using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            lbl3.Text = "";
            txt1.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do you really want to exit the program?",
                "Exit now?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                {
                    Application.Exit();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool result = true;
            double num1 = 0.0;
            double num2 = 0.0;
            double sum = 0.0;
            double diff = 0.0;
            double prod = 0.0;
            double quot = 0.0;
            string outputStr = "";

            //Check for empty input textbox 1
            if (txt1.Text.Trim() == "")
            {
                MessageBox.Show("No input for the first textbox!",
                    "TextBox empty!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt1.Focus();
                return;
            }

            //Check for empty input textbox 2
            if (txt2.Text.Trim() == "")
            {
                MessageBox.Show("No input for the second textbox!",
                    "TextBox empty!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt2 .Focus();
                return;
            }

            //Check for non-numeric input textbox 1
            result = double.TryParse(txt1.Text, out num1);

            if (!result) 
            {
                MessageBox.Show("Non-Numeric input for the first textbox!",
                    "TextBox Non-Numeric",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt1.Text = "";
                txt1.Focus();
                return;
            }

            //Check for non-numeric input textbox 2
            result = double.TryParse(txt2.Text, out num2);

            if (!result) {
                MessageBox.Show("Non-Numeric input for the second textbox!",
                    "TextBox Non-Numeric",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txt2.Text = "";
                txt2.Focus();
                return;              
            }

            num1 = double.Parse(txt1.Text);
            num2 = double.Parse(txt2.Text);

            sum = num1 + num2;
            diff = num1 - num2;
            prod = num1 * num2;
            quot = num1 / num2;

            outputStr += txt1.Text + " + " + txt2.Text + " = " + sum.ToString("n2") + "\n";
            outputStr += txt1.Text + " - " + txt2.Text + " = " + diff.ToString("n2") + "\n";
            outputStr += txt1.Text + " * " + txt2.Text + " = " + prod.ToString("n2") + "\n";
            outputStr += txt1.Text + " / " + txt2.Text + " = " + quot.ToString("n2") + "\n";
            lbl4.Text = outputStr;
            
        }
    }
}
