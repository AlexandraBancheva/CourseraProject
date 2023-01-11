using Coursera.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursera.Data
{
    public class CourseraContext : DbContext
    {
        public CourseraContext() { 
        }

        public CourseraContext(DbContextOptions options)
            : base(options) 
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=coursera;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity.HasKey(k => new { k.PIN, k.CourseId });
            });
        }
    }
}
