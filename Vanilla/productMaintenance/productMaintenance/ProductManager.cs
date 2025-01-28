//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace productMaintenance
//{
//    internal class ProductManager
//    {


//    }
//}

using System.Collections.Generic;   // Needed for List

public class ProductManager
{
    private List<Product> products = new List<Product>();  // List to store products
    private int nextId = 1; // Variable to track the next product ID

    // Method to add a new product
    public void AddProduct(string name, string description)
    {
        // Create a new Product object with the next available ID
        Product newProduct = new Product(nextId++, name, description);
        products.Add(newProduct);   // Add the new product to the list
    }

    // Method to delete a product by ID
    public bool DeleteProduct(int id)
    {
        // Find the product with the specified ID
        Product productToRemove = products.Find(p => p.Id == id);
        if (productToRemove != null) // If found
        {
            products.Remove(productToRemove);   // Remove the product
            return true;    // Return true indicating successful deletion
        }
        return false;   // Return false if not found
    }
    // Method to retrieve the list of products
    public List<Product> GetProducts()
    {
        return products;    // Return the list of products
    }
}