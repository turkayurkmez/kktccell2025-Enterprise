using Catalog.Application.Contracts;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Queries.SelectAll
{
    public class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, GetAllProductsResponse>
    {

        private readonly IProductRepository productRepository;

        public GetAllProductsRequestHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<GetAllProductsResponse> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var products = await productRepository.GetAll();

            var productsCount = products.Count();
            var productInfos = products.Adapt<IEnumerable<GetAllProductInfo>>();
            var maxPrice = products.Max(x => x.Price);
            var avgPrice = products.Average(x => x.Price);

            return new GetAllProductsResponse(productsCount, avgPrice, maxPrice, productInfos);

        }
    }
}
