using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqDemoWindowsForms
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //  1. Create a sample list of Students objects
            List<Student> students = new List<Student>
            {
                new Student {Name = "Alice", Age = 19},
                new Student {Name = "Bob", Age = 22},
                new Student {Name = "Charlie", Age = 24},
                new Student {Name = "Diana", Age = 18}
            };

            //  2. Use LINQ to filter students who are older than 20
            var filteredStudents = from student in students
                                   where student.Age > 20
                                   select student;

            //  3. Display the filtered list in the DataGridView
            dataGridViewResults.DataSource = filteredStudents.ToList();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
