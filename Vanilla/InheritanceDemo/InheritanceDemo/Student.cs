////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace InheritanceDemo
//{
    internal class Student : Person
    {
        // Property to store the student's ID
        public int StudentID { get; set; }

        // Constructor to initialize the student's first name, last name, and ID
        // 'base' keyword is used to call the parent (Person) constructor 
        public Student(string firstName, string lastName, int studentID)
            : base(firstName, lastName) // Pass first and last name to the Person class
        {
            StudentID = studentID; // Set the StudentID property
        }

        // This method overrides the GetFullName method of the Person class 
        public override string GetFullName()
        {
            // Call the base (Person) method to get the full name, then add the student ID
            return $"{base.GetFullName()} (Student ID: {StudentID})";
        }
    }
//}
