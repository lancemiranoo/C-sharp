using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string lbl1 = txt1.Text;
            decimal lbl2 = 
                Convert.ToDecimal(txt2.Text);
            decimal lbl3 = .0m;

            if (lbl1 == "R")
            {
                if (lbl2 < 100)
                    lbl3 = .0m;
                else if (lbl2 >= 100 && lbl2 < 250)
                    lbl3 = .1m;
                else if (lbl2 >= 250)
                    lbl3 = .25m;
            }

            else if (lbl1 == "C")
            {
                if (lbl2 < 250)
                    lbl3 = .2m;
                else
                    lbl3 = .3m;
            }

            else
            {
                lbl3 = .4m;
            }

            decimal discountAmt = lbl2 * lbl3;
            decimal invoiceTotal = lbl2 - lbl3;
            txt3.Text = lbl3.ToString("p1");
            txt4.Text = lbl4.ToString("c");
            txt5.Text = lbl5.ToString("c");
            txt1.Focus();
        }
    }
}
