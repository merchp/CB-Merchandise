using Microsoft.EntityFrameworkCore;

namespace CBMerch.Models
{
    public class CBMerchDbContext : DbContext 
    {
        public CBMerchDbContext(DbContextOptions<CBMerchDbContext> options)
            :base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
