using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using StudentProjectAPI.Entity;

namespace StudentProjectAPI.Repository
{
    // DbContext class for interacting with the database
    public class StudentDbContext : DbContext
    {
        // DbSet representing the students table in the database
        public DbSet<Student> students { get; set; }

        // Method for configuring the DbContext options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Connection string for MySQL database
            string conString = @"server=localhost;port=3306;user=root;password=root;database=studentp;";
            optionsBuilder.UseMySQL(conString); // Configuring DbContext to use MySQL provider with the specified connection string
        }

        // Method for configuring the model schema
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring entity mappings for Student entity
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Student_ID); // Setting Student_ID as the primary key
                entity.Property(e => e.Student_Name); // Configuring properties
                entity.Property(e => e.Student_Email);
                entity.Property(e => e.Mobile_number);
                entity.Property(e => e.Student_Address);
                entity.Property(e => e.admission_date);
                entity.Property(e => e.fees);
                entity.Property(e => e.Status);
            });

            modelBuilder.Entity<Student>().ToTable("studentp"); // Mapping Student entity to a table named "studentp"
        }
    }
}
