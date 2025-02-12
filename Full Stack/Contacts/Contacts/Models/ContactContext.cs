using Microsoft.EntityFrameworkCore;

namespace Contacts.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friend" },
                new Category { CategoryId = 2, Name = "Work" },
                new Category { CategoryId = 3, Name = "Family" },
                new Category { CategoryId = 4, Name = "Acquaintance" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FName = "Joaquin",
                    LName = "Remulla",
                    PNumber = "825-841-1779",
                    Email = "joaquin@gmail.com",
                    CategoryId = 1,
                    Organization = " ",
                    DateAdded = new DateTime(2025,2,10)
                },
                new Contact
                {
                    ContactId = 2,
                    FName = "Charles",
                    LName = "Omagap",
                    PNumber = "825-914-4912",
                    Email = "charles@gmail.com",
                    CategoryId = 2,
                    Organization = " ",
                    DateAdded = new DateTime(2025, 2, 10)
                },
                new Contact
                {
                    ContactId = 3,
                    FName = "Hanni",
                    LName = "Pham",
                    PNumber = "825-514-5015",
                    Email = "hanni@gmail.com",
                    CategoryId = 3,
                    Organization = " ",
                    DateAdded = new DateTime(2025, 2, 10)
                }
            );
        }
    }
}
