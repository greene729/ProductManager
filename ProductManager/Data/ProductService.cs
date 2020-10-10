using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class ProductService
    {
        private readonly ProductDbContext _dbContext;

        public ProductService(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            try
            {
                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            try
            {
                var productToUpdate = _dbContext.Products.FirstOrDefault(p => p.Id == product.Id);
                if (productToUpdate != null)
                {
                    _dbContext.Update(product);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch(Exception)
            {
                throw;
            }
            return product;
        }

        public async Task DeleteProductAsync(Product product)
        {
            try
            {
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
