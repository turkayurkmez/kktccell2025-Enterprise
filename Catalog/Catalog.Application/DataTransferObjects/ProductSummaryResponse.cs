using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.DataTransferObjects
{
    public record ProductSummaryResponse(
        Guid Id,
        string Name,
        string Description,
        decimal Price, 
        string? ImageUrl);


}
