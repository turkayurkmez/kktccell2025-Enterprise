using Catalog.Application.Contracts;
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            var products = new List<Product>()
            {
                new Product("Ürün A1","Desc A1",1,10,string.Empty,1),
                new Product("Ürün A2","Desc A2",1,10,string.Empty,1),
                new Product("Ürün A3","Desc A3",1,10,string.Empty,1),
                new Product("Ürün A3","Desc A4",1,10,string.Empty,1),

            };
            return Task.FromResult(products.AsEnumerable());
        }

        public Task<Product> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
