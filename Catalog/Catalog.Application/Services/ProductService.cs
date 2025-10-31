using Catalog.Application.Contracts;
using Catalog.Application.DataTransferObjects;
using Catalog.Application.Results;
using Catalog.Entities;
using Mapster;
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

        public ProductsResponseResult GetProductsForMainPage()
        {
            //db'den product olarak gelecek.
            var products = productRepository.GetAll().Result;


            //var dto = products.Select(p => new ProductSummaryResponse(
            //    Id: p.Id, 
            //    Name: p.Name, 
            //    Description: p.Description, 
            //    Price: p.Price, 
            //    ImageUrl: p.ImageUrl));

            //mapster ile:
            var dto = products.Adapt<IEnumerable<ProductSummaryResponse>>();

            return new ProductsResponseResult
            {
                IsSuccess = true,
                Products = dto,
                Message = $"İşlem başarılı. Toplam {dto.Count()} adet ürün çekildi"
            };
        }



        //Yeni ürün ekler
        //Ürün var mı kontrolü
        //Kategoriye göre arama
        //Ada göre arama.



    }
}
