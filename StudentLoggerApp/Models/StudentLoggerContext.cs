using Microsoft.EntityFrameworkCore;
namespace StudentLoggerApp.Models
{
    public class StudentLoggerContext: DbContext
    { 

        public StudentLoggerContext(DbContextOptions<StudentLoggerContext> options)
            : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EnrolledIn> EnrolledIns { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
