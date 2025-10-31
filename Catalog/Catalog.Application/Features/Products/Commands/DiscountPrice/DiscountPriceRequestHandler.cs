using Catalog.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Commands.DiscountPrice
{
    public class DiscountPriceRequestHandler : IRequestHandler<DiscountPriceRequest,DiscountPriceCommandResponse>
    {
        private readonly IProductRepository productRepository;

        public DiscountPriceRequestHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Task<DiscountPriceCommandResponse> Handle(DiscountPriceRequest request)
        {
            //db işlemleri....
            var product = productRepository.GetById(request.ProductId);
            product.Result.ApplyDiscount(request.discountRate);

            productRepository.Update(product.Result);

            return Task.FromResult(new DiscountPriceCommandResponse(true, "Ürün fiyatında indirim yapıldı"));

        }

        public async Task<DiscountPriceCommandResponse> Handle(DiscountPriceRequest request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetById(request.ProductId);
            product.ApplyDiscount(request.discountRate);

            await productRepository.Update(product);

            return new DiscountPriceCommandResponse(true, "Ürün fiyatında indirim yapıldı");
        }
    }
}
