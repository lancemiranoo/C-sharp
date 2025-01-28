namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int theNumber;
            Random number = new Random();
            theNumber = number.Next(101);
            txt1.Text = theNumber.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt1.Focus();
        }
    }
}
