﻿using System;
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
            return new List<Product>
            {
                new Product { Id = 1001, Name = "Laptop", Price = 20.02, Quantity = 10, Description ="This is a best gaming laptop"},
                new Product { Id = 1002, Name = "Microsoft Office", Price = 20.99, Quantity = 50, Description ="This is a Office Application"},
                new Product { Id = 1003, Name = "Lazer Mouse", Price = 12.02, Quantity = 20, Description ="The mouse that works on all surface"},
                new Product { Id = 1004, Name = "USB Storage", Price = 5.00, Quantity = 20, Description ="To store 256GB of data"}

            };
        }
    }
}
