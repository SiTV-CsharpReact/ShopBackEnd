using Microsoft.EntityFrameworkCore;
using ShopBackEnd.Entities;
using System.Collections.Generic;

namespace ShopBackEnd.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}
