using Catalog.Entities;

namespace Catalog.Application.Services
{
    public interface IProductService
    {
        void DiscountPrice(int productId, decimal discountRate);
        List<Product> GetProducts();
    }
}