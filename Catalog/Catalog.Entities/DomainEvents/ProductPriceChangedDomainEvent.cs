using Catalog.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities.DomainEvents
{
    public class ProductPriceChangedDomainEvent: DomainEvent
    {
        public Guid ProductId { get; private set; }
        public decimal OldPrice { get; private set; }
        public decimal NewPrice { get; private set; }

        public ProductPriceChangedDomainEvent(Guid productId, decimal oldPrice, decimal newPrice)
        {
            ProductId = productId;
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
