using Catalog.Application.Contracts;
using Catalog.Application.DataTransferObjects;
using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Services
{
    public class ProductService : IProductService
    {
        //Uygulama, Ürün varlığı ile .............. yapıyor.

        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void DiscountPrice(int productId, decimal discountRate)
        {
            //git, ürünü bul ve fiyatında indirim uygula!
            //o zaman ürünü NASIL bulacağım?
        }

        public IEnumerable<ProductSummaryResponse> GetProductsForMainPage()
        {
            //db'den product olarak gelecek.
            var products = productRepository.GetAll().Result;
            return products.Select(p => new ProductSummaryResponse(Id: p.Id, Name: p.Name, Description: p.Description, Price: p.Price, ImageUrl: p.ImageUrl));
        }



        //Yeni ürün ekler
        //Ürün var mı kontrolü
        //Kategoriye göre arama
        //Ada göre arama.



    }
}
