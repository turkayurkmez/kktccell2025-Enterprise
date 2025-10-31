using Catalog.Application.DataTransferObjects;
using Catalog.Application.Results;
using Catalog.Entities;

namespace Catalog.Application.Services
{
    public interface IProductService
    {
        void DiscountPrice(int productId, decimal discountRate);

        ProductsResponseResult GetProductsForMainPage();


    }
}