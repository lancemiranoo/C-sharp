using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoices
{
    public partial class Invoice: UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }
        int numberOfInvoices = 0;
        decimal invoiceDollarTotal = 0M;
        decimal averageInvoiceAmount = 0M;

        private void btn1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0M;
        }
    }
}
