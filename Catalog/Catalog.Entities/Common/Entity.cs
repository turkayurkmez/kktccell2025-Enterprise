using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities.Common
{
    public abstract class Entity<T> where T: struct, IEquatable<T> 
    {
        public T Id { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public DateTime? UpdatedDate { get; protected set; }

        protected Entity()
        {
            CreatedDate = DateTime.Now;
            Id = typeof(T) == typeof(Guid) ?(T)(object) Guid.NewGuid() : default!;
        }




    }
}
