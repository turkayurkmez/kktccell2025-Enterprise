using Catalog.Application.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Services
{
    public class FalancaProductService : IProductService
    {
        public void DiscountPrice(int productId, decimal discountRate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductSummaryResponse> GetProductsForMainPage()
        {
            return new List<ProductSummaryResponse>()
            {
                new ProductSummaryResponse(1,"Falanca Ürün A", "Açıklama A1", 1,string.Empty),
                new ProductSummaryResponse(2,"Falanca Ürün B", "Açıklama A2", 1,string.Empty),
                new ProductSummaryResponse(3,"Falanca Ürün C", "Açıklama A3", 1,string.Empty),
                new ProductSummaryResponse(4,"Falanca Ürün D", "Açıklama A4", 1,string.Empty),

            };
        }
    }
}
