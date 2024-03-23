using APICoreDocker.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APICoreDocker.DBContext
{
    public interface IStudentContext
    {
        DbSet<Student> Students { get; set; }

        Task<int> SaveChanges();
    }
}