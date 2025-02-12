using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact
    {
        // EF Core will configure the database to generate this value
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Please enter a first name.")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Please enter a last name.")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PNumber { get; set; }
        [Required(ErrorMessage = "Please enter a email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please choose a category.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? Organization {  get; set; }
        public DateTime DateAdded { get; set; }
    }
}
