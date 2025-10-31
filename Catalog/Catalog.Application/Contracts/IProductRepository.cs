using Catalog.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Contracts
{
    public interface IProductRepository : IRepository<Product,Guid>
    {
        Task<IEnumerable<Product>> SearchByName(string name);
        Task<IEnumerable<Product>> GetProductsByCategoryId(int categoryId);

    }
}
