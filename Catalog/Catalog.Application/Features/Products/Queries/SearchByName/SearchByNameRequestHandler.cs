using Catalog.Application.Contracts;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Queries.SearchByName
{
    public class SearchByNameRequestHandler : IRequestHandler<SearchByNameRequest, SearchByNameResponse>
    {

        private readonly IProductRepository productRepository;

        public SearchByNameRequestHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<SearchByNameResponse> Handle(SearchByNameRequest request, CancellationToken cancellationToken)
        {
            var products = await productRepository.SearchByName(request.Name);
            var result = products.Adapt<IEnumerable<SearchByNameResult>>();

            return new SearchByNameResponse(result, Message: "Veriler başarıyla çeklidi", true);



        }
    }
}
