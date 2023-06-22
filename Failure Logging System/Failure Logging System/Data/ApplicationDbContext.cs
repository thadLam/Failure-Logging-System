using Microsoft.EntityFrameworkCore;

namespace Failure_Logging_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Failure_Logging_System.Models.Driver> Drivers { get; set; }
    }
}
