using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            Person person = null;

            if (cmbRole.SelectedItem.ToString() == "Student")
            {
                person = new Student { FirstName = firstName, LastName = lastName };
            }
            else if (cmbRole.SelectedItem.ToString() == "Teacher")
            {
                person = new Teacher { FirstName = firstName, LastName = lastName };
            }
            else
            {
                person = new Person { FirstName = firstName, LastName = lastName };
            }
            lblOutput.Text = person.GetInfo(); 
        }
    }
}
