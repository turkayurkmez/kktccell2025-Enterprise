using Catalog.Application.DataTransferObjects;
using Catalog.Entities;

namespace Catalog.Application.Services
{
    public interface IProductService
    {
        void DiscountPrice(int productId, decimal discountRate);
        
        IEnumerable<ProductSummaryResponse> GetProductsForMainPage();


    }
}