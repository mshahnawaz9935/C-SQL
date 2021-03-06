using MVCTest2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCTest2.DAL
{
        public class SchoolContext : DbContext
        {
            public SchoolContext() : base()
            {
            }
            public DbSet<Student> Students { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
        }

}