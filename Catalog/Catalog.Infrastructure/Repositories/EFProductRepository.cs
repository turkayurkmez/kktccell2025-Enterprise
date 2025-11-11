using Catalog.Application.Contracts;
using Catalog.Entities;
using Catalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class EFProductRepository(CatalogDbContext catalogDbContext) : IProductRepository
    {


        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await catalogDbContext.Products.ToListAsync();
        }

        public Task<Product> GetById(Guid id)
        {
            return catalogDbContext.Products.FirstOrDefaultAsync(p=>p.Id == id);
        }

        public Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> SearchByName(string name)
        {
            var products = await catalogDbContext.Products.Where(p => p.Name.Contains(name)).ToListAsync();

            return products;
        }

        public async Task Update(Product entity)
        {
            catalogDbContext.Products.Update(entity);
            await catalogDbContext.SaveChangesAsync();
        }
    }
}
