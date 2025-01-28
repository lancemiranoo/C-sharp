using Microsoft.EntityFrameworkCore;


public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; } // Table
    protected override void OnConfiguring(DbContextOptionsBuilder
   optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=StudentEFDB; Trusted_Connection = True;");
    }
}
