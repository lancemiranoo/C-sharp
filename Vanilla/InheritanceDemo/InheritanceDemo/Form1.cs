using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the user input from the textboxes 
            string firstName = txtFirstName.Text; // Get the first name
            string lastName = txtLastName.Text; // Get the last name
            int studentID;

            // Try to convert the Student ID from string to integer
            if (int.TryParse(txtStudentID.Text, out studentID) )
            {
                // Create a Student object using the first name, last name, and student ID
                Student student = new Student (firstName, lastName, studentID);

                // Display the full name along with the student ID using the overriden method
                txtShowFullName.Text = student.GetFullName();
            }
            else
            {
                // Show an error message if the Student ID is not a valid number
                txtShowFullName.Text = "Invalid Student ID. Please enter a valid number.";
            }
        }
    }
}
