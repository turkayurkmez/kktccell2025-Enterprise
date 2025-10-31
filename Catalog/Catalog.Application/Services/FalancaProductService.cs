using Catalog.Application.DataTransferObjects;
using Catalog.Application.Results;
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

        public ProductsResponseResult GetProductsForMainPage()
        {
            //return new List<ProductSummaryResponse>()
            //{
            //    new ProductSummaryResponse(Guid.NewGuid(),"Falanca Ürün A", "Açıklama A1", 1,string.Empty),
            //    new ProductSummaryResponse(Guid.NewGuid(),"Falanca Ürün B", "Açıklama A2", 1,string.Empty),
            //    new ProductSummaryResponse(Guid.NewGuid(),"Falanca Ürün C", "Açıklama A3", 1,string.Empty),
            //    new ProductSummaryResponse(Guid.NewGuid(),"Falanca Ürün D", "Açıklama A4", 1,string.Empty),

            //};

            throw new NotImplementedException();
        }
    }
}
