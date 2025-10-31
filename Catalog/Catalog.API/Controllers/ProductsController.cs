using Catalog.Application.Features.Products.Commands.DiscountPrice;
using Catalog.Application.Services;
using Catalog.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

       // private readonly IProductService productService;
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            //this.productService = productService;
            this.mediator = mediator;
        }


        [HttpGet]
        public IActionResult Get()
        {
            //ProductService productService = new ProductService();
            //  var products = productService.GetProductsForMainPage();
            // return Ok(products);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> DiscountPrice(DiscountPriceRequest request)
        {
            //FakeProductRepository fakeProductRepository = new FakeProductRepository();
            //DiscountPriceRequestHandler handler = new DiscountPriceRequestHandler(fakeProductRepository);
            //var response = await handler.Handle(request);

            //mediatR paketi ile:

            var response =  await  mediator.Send(request);

            return Ok(response);    
        }


    }
}
