using Catalog.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Contracts
{
    public interface IRepository<T,TId> where T : IAggregateRoot, new()
                                        where TId: struct, IEquatable<TId>

    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

        Task Create(T entity);
        Task Update(T entity);
        Task Delete(TId id);
    }
}
