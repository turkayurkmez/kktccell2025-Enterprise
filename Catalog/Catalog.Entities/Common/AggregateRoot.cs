using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities.Common
{
    /*
     * Aggregate, birden fazla Entity'yi yöneten bir entity'dir. 
     * order.OrderItems.Add(new OrderItem());
     * order.WithCustomer(new Customer());
     */
    public class AggregateRoot<T> : Entity<T>, IAggregateRoot where T : struct, IEquatable<T>
    {
        private readonly List<IDomainEvent> domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

        public void ClearDomainEvents()
        {
            domainEvents.Clear();
        }

        protected void AddDomainEvent(IDomainEvent domainEvent) => domainEvents.Add(domainEvent);
    }
}
