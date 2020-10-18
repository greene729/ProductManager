using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>();
        }
    }
}
