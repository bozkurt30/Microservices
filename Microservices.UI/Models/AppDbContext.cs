using Microservices.UI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.UI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
