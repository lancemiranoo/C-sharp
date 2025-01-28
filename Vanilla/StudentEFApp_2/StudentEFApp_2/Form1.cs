namespace StudentEFApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new StudentContext())
            {
                // Fetch data from the database
                var students = context.Students.ToList();
                // Display data in the DataGridView
                dataGridViewStudents.DataSource = students;
            }
        }
    }
}


