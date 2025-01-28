//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceDemo
//{
    internal class Person
    {
        // Properties to store the person's first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize the first and last name
        public Person(string firstName, string lastName)
        {
            FirstName = firstName; // Set the FirstName property
            LastName = lastName; // Set the LastName property
        }

        // A method that returns the full name of the person
        // The 'virtual' keyword allows this methods to be overridden in a derived class
        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}"; // Return first name and last name
        }
    }
//}
