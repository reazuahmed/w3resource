using Employee_Manager.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employee_Manager.Data
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
