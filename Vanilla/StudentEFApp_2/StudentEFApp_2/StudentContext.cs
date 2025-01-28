using Microsoft.EntityFrameworkCore;
public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; } // Table
    protected override void OnConfiguring(DbContextOptionsBuilder
   optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentEFDB; Trusted_Connection = True; ");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
        new Student { ID = 1, Name = "Alice", Age = 20, Grade = "A" },
        new Student { ID = 2, Name = "Bob", Age = 21, Grade = "B" },
        new Student { ID = 3, Name = "Charlie", Age = 22, Grade = "A" }
        );
    }
}