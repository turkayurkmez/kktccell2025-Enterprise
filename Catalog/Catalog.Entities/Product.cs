using Catalog.Entities.Common;
using Catalog.Entities.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public class Product : AggregateRoot<Guid>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public decimal Price { get; private set; }
        public int? Stock { get; private set; }

        public string? ImageUrl { get; private set; }

        public int? CategoryId { get; set; }

        //Navigation property: EF tarafından kullanılacak
        public Category? Category { get;  set; }

        public Product()
        {
            
        }

        public Product(string name, string description, decimal price, int? stock, string? imageUrl, int? categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
        }

        public void ApplyDiscount(decimal discountRate) {

            if (discountRate<0)
            {
                throw new ArgumentOutOfRangeException("indirim oranı negatif olamaz!");
            }
            var oldPrice = Price;
            Price = Price * (1 - discountRate);

            //Tam da burada, bir olay tetiklenebilir. Mecbur değilsiniz. Ama mümkün

            ProductPriceChangedDomainEvent @event = new ProductPriceChangedDomainEvent(this.Id, oldPrice, Price);

            AddDomainEvent(@event);

        }

    }
}
