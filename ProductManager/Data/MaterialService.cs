using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductManager.Data
{
    public class MaterialService
    {
        private readonly ProductDbContext _dbContext;

        public MaterialService(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Material>> GetMaterialsAsync()
        {
            return await _dbContext.Materials.ToListAsync();
        }
        
        public async Task<Material> AddMaterialAsync(Material material)
        {
            try
            {
                _dbContext.Materials.Add(material);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return material;
        }
        
        public async Task<Material> UpdateMaterialAsync(Material material)
        {
            try
            {
                var materialToUpdate = _dbContext.Materials.FirstOrDefault(p => p.Id == material.Id);
                if (materialToUpdate != null)
                {
                    _dbContext.Materials.Update(material);
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch(Exception)
            {
                throw;
            }
            return material;
        }

        public async Task DeleteMaterialAsync(Material material)
        {
            try
            {
                _dbContext.Materials.Remove(material);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}