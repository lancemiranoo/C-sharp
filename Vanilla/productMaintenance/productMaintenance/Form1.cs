using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productMaintenance
{
    public partial class Form1 : Form
    {
        // Instance of Product Manager to manage products
        private ProductManager productManager = new ProductManager();

        // Constructor for the form
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Get product name and description from the input fields
            string productName = txtProductName.Text;   // Get name from TextBox
            string productDescription = txtProductDescription.Text; // Get description from TextBox

            // Check if the name and description are not empty
            if (!string.IsNullOrWhiteSpace(productName) && !string.IsNullOrWhiteSpace(productDescription))
            {
                //  Add the product using the manager
                productManager.AddProduct(productName, productDescription);
                UpdateProductList(); // Refresh the product list display
                txtProductName.Clear(); // Clear the input fields
                txtProductDescription.Clear();  // Clear the description field
            }
            else
            {
                // Show an error message if inputs are invalid
                MessageBox.Show("Please enter a product name and description.");    // Display message box
            }
        }

        // Event handler for deleting a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Try to parse the product ID from the input field
            if (int.TryParse(txtProductId.Text, out int productId))
            {
                // Attempt to delete the product and check if it was successful
                if (productManager.DeleteProduct(productId))
                {
                    UpdateProductList();    // Refresh the product list display
                    txtProductId.Clear();   // Clear the ID input field
                }
                else
                {
                    // Show an error message if the product ID was not found
                    MessageBox.Show($"Product with ID {productId} not found."); //Display message
                }
            }
            else
            {
                // Show an error message if the ID input is invalid
                MessageBox.Show("Please enter a valid product ID.");    // Display message

            }
        }

        // Event handler for the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        // Method to update the product list display in the ListBox
        private void UpdateProductList()
        {
            lstList.Items.Clear();   // Clear the current items in the ListBox
            foreach (var product in productManager.GetProducts()) // Loopp through each product
            {
                lstList.Items.Add(product); // Add each product to the ListBox
            }
        }
    }
}
