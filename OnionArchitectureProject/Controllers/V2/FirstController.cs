using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Application.Services;

namespace OnionArchitectureProject.Controllers.V2
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstController : ControllerBase
    {
        private readonly IProductService _productService;
        public FirstController(IProductService service) 
        {
            _productService = service;
        }

        [HttpGet("GetVersion2")]
        public string Get()
        {
            return "data from api v2";
        }

        [HttpGet("GetProById")]
        public IActionResult GetProductById(int productid) 
        {
            var product = _productService.GetProductById(productid);
            return Content(product.Title);
        }
    }
}
