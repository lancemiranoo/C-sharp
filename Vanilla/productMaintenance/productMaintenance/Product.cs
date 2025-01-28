//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace productMaintenance
//{
//    internal class Product
//    {
        
//    }
//}

public class Product
{
    // Properties of the Product Class
    public int Id { get; set; } // Unique identifier for the product
    public string Name { get; set; } // Name of the product
    public string Description { get; set; } // Description of the product

    // Constructor to initialize product properties
    public Product(int id, string name, string description)
    {
        Id = id;                    // Set the ID
        Name = name;                // Set the name
        Description = description;  // Set the description
    }
    // Override ToString method for displaying product details in the ListBox
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Description: {Description}";   // Display format
    }
}
