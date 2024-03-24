using Microsoft.EntityFrameworkCore;
using StudentMicroservices.Models;
using System.Threading.Tasks;

namespace StudentMicroservices.DBContext
{
    public class StudentContext : DbContext, IStudentContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentID> StudentID { get; set; }
        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Age = 30,
                    Name = "K P and team",
                    Roll = 234,
                    Class = 34,
                    Section = ".NET Core API"
                }
            );
        }
    }
}
