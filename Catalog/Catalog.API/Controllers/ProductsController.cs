using Catalog.Application.Features.Products.Commands.DiscountPrice;
using Catalog.Application.Features.Products.Queries.SearchByName;
using Catalog.Application.Features.Products.Queries.SelectAll;
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
        public async Task<IActionResult> Get()
        {
            //ProductService productService = new ProductService();
            //var products = productService.GetProductsForMainPage();
            //return Ok(products);

            var request = new GetAllProductsRequest();
            var response = await mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> DiscountPrice(DiscountPriceRequest request)
        {
            //FakeProductRepository fakeProductRepository = new FakeProductRepository();
            //DiscountPriceRequestHandler handler = new DiscountPriceRequestHandler(fakeProductRepository);
            //var response = await handler.Handle(request);

            //mediatR paketi ile:

           //request.discountRate = 0.20m;
            var response =  await  mediator.Send(request);

            return Ok(response);    
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name) { 
            var request = new SearchByNameRequest(name);
            var response = await mediator.Send(request);

            return Ok(response);

        }


    }
}
