using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
