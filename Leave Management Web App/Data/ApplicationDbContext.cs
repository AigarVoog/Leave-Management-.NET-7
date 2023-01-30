using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leave_Management_Web_App.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // create a table in the database called LeaveTypes
        public DbSet<LeaveType> LeaveTypes { get; set; }

        // create a table in the database called LeaveAllocations
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}