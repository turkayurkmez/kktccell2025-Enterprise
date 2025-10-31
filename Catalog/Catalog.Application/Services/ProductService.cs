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

        public void DiscountPrice(int productId, decimal discountRate)
        {
            //git, ürünü bul ve fiyatında indirim uygula!
            //o zaman ürünü NASIL bulacağım?
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        //Yeni ürün ekler
        //Ürün var mı kontrolü
        //Kategoriye göre arama
        //Ada göre arama.



    }
}
