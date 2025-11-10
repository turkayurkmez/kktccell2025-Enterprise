using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Queries.SearchByName
{
    public  record SearchByNameRequest(string Name) : IRequest<SearchByNameResponse>;

    public record SearchByNameResult(Guid Id, string Name, string? ImageUrl);

    public record SearchByNameResponse(IEnumerable<SearchByNameResult> Results, string? Message, bool IsSuccess);

   
}
