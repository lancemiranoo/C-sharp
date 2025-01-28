using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManager
{
    public partial class Form1 : Form
    {
        // Arrays to store student names and grades
        string[] studentNames = new string[10]; // Array to store student names
        int[] studentGrades = new int[10]; // Array to store grades

        // Variable to keep track of the number of students
        int index = 0; // Start from 0, increments as students are added

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (index <10) // Check if the arrays are not full
            {
                studentNames[index] = txtStudentName.Text; // Store the student name
                studentGrades[index] = int.Parse(txtGrade.Text); // Store the grade
                index++; // Increment the index
                MessageBox.Show("Grade added successfully!");
                txtStudentName.Clear();
                txtGrade.Clear();
            }
            else
            {
                MessageBox.Show("Maximum number of students reached!");
            }
        }

        private void btnShowGrade_Click(object sender, EventArgs e)
        {
            lb1stGrades.Items.Clear(); // Clear previous items in the ListBox
            for (int i = 0; i < index; i++) // Loop through the array 
            {
                lb1stGrades.Items.Add($"{studentNames[i]} - {studentGrades[i]}"); // Display the student grade and name
            }
        }

        private void btnCalculateAvg_Click(object sender, EventArgs e)
        {
            int total = 0; // Variable to hold the sum of grades
            for (int i = 0;i < index;i++) // Loop through the array
            {
                total += studentGrades[i]; // Calculate the sum
            }
            double average = (double)total / index; // Calculate the average
            MessageBox.Show($"The average grade is: {average:F2}"); // Display the average 
        }
    }
}
