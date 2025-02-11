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
                new Category { CategoryId = "A", Name = "Friend" },
                new Category { CategoryId = "B", Name = "Work" },
                new Category { CategoryId = "C", Name = "Family" },
                new Category { CategoryId = "D", Name = "Acquaintance" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FName = "Joaquin",
                    LName = "Remulla",
                    PNumber = "825-841-1779",
                    Email = "joaquin@gmail.com",
                    CategoryId = "D",
                    Organization = " "
                },
                new Contact
                {
                    ContactId = 2,
                    FName = "Charles",
                    LName = "Omagap",
                    PNumber = "825-914-4912",
                    Email = "charles@gmail.com",
                    CategoryId = "A",
                    Organization = " "
                },
                new Contact
                {
                    ContactId = 3,
                    FName = "Hanni",
                    LName = "Pham",
                    PNumber = "825-514-5015",
                    Email = "hanni@gmail.com",
                    CategoryId ="C",
                    Organization = " "
                }
            );
        }
    }
}
