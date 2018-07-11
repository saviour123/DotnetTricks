using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            // constructor
        }

    public DbSet<Customer> Customer { get; set; }
    
    }

}