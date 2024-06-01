using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace lab11_DAEA.Models
{
    public class SchoolContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-0ORAP2JU\\SQLEXPRESS; Initial Catalog = Lab11DB; User Id = userXavier; Password = 123456; Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
