using Microsoft.EntityFrameworkCore;
using StudentMicroservices.Models;
using System.Threading.Tasks;

namespace StudentMicroservices.DBContext
{
    public interface IStudentContext
    {
        DbSet<StudentID> StudentID { get; set; }
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}