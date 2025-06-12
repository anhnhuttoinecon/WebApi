using Microsoft.EntityFrameworkCore;

namespace WebApi.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
     options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
