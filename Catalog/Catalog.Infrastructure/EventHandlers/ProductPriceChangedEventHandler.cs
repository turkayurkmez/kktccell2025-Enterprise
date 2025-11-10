using Catalog.Entities.DomainEvents;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.EventHandlers
{
    public class ProductPriceChangedEventHandler : INotificationHandler<ProductPriceChangedDomainEvent>
    {

        private readonly ILogger<ProductPriceChangedEventHandler> _logger;

        public ProductPriceChangedEventHandler(ILogger<ProductPriceChangedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(ProductPriceChangedDomainEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{notification.ProductId} id'li  Ürünün fiyatı güncellendi. Eski fiyat: {notification.OldPrice}, yeni fiyat ise {notification.NewPrice} oldu ");

            return Task.CompletedTask;
        }


    }
}
