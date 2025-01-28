using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalSoundApp
{
    public partial class MainForm : Form
    {
        private List<ISound> animals;
        public MainForm()
        {
            InitializeComponent();
            // Initialize the animal list
            animals = new List<ISound> { new Dog(), new Cat(), new Dog(), new Cat() };
            // Add animals to ComboBox
            cmbAnimals.Items.Add("Dog");
            cmbAnimals.Items.Add("Cat");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowSound_Click(object sender, EventArgs e)
        {
            // Check if an animal is selected 
            int selectedIndex = cmbAnimals.SelectedIndex;
            if (selectedIndex >= 0)
            {
                // Get the selected animal and display its sound
                ISound selectedAnimal = animals[selectedIndex];
                lblSound.Text = $"This is a {((Animal)selectedAnimal).Type}.";
                selectedAnimal.MakeSound(); // Calls the MakeSound method of the selected animal
            } 
            else
            {
                MessageBox.Show("Please select an animal.");
            }
        }
    }
}
