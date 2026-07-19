using Microsoft.EntityFrameworkCore;
using MgqsStudentPortal.Models;

namespace MgqsStudentPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
