using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Products.Commands.DiscountPrice
{
    public record DiscountPriceRequest(Guid ProductId, decimal discountRate) : IRequest<DiscountPriceCommandResponse> ;   
    
    public record DiscountPriceCommandResponse(bool IsSuccess, string? Message);
}
