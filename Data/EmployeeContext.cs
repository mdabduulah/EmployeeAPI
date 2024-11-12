using Microsoft.EntityFrameworkCore;
using EmployeeAPI.models; 

namespace EmployeeAPI.Data
{
    public class EmployeeContext : DbContext
    {
       
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

 
        public DbSet<Employee> Employees { get; set; }
    }
}

