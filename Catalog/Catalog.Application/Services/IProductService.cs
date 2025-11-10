using Catalog.Application.DataTransferObjects;
using Catalog.Application.Results;
using Catalog.Entities;

namespace Catalog.Application.Services
{
    public interface IProductService
    {

        //Ben, product nesnesiyle ................ yaparım  
        void DiscountPrice(int productId, decimal discountRate);

        ProductsResponseResult GetProductsForMainPage();


    }
}