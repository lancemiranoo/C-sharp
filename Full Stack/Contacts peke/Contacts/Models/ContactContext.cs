using Microsoft.EntityFrameworkCore;

namespace Contacts.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set;}

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FName = "Joaquin",
                    LName = "Remulla",
                    PNumber = "825-841-1779",
                    Email = "joaquin@gmail.com"
                },
                new Contact
                {
                    ContactId = 2,
                    FName = "Charles",
                    LName = "Omagap",
                    PNumber = "825-914-4912",
                    Email = "charles@gmail.com"
                },
                new Contact
                {
                    ContactId = 3,
                    FName = "Hanni",
                    LName = "Pham",
                    PNumber = "825-514-5015",
                    Email = "hanni@gmail.com"
                }
            );
        }
    }
}
