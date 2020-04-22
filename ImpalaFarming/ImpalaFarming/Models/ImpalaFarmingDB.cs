using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImpalaFarming.Models
{
    public class ImpalaFarmingDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CreditCardInfo> CreditCardInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=ImpalaFarmingDb.db");
        }
    }
}
