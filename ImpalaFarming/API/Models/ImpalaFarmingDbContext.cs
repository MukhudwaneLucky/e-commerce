using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class ImpalaFarmingDbContext : DbContext
    {
        public ImpalaFarmingDbContext(DbContextOptions<ImpalaFarmingDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    }
}
