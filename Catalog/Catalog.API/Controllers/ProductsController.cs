using Catalog.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            //ProductService productService = new ProductService();
            var products = productService.GetProductsForMainPage();
            return Ok(products);
        }



    }
}
