using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Queries.SelectAll
{
    public record GetAllProductsRequest() : IRequest<GetAllProductsResponse>;

    public record GetAllProductsResponse(int Count, decimal AveragePrice, decimal MaxPrice, IEnumerable<GetAllProductInfo> Products );

    public record GetAllProductInfo(Guid Id, string Name, decimal Price);







    
}
