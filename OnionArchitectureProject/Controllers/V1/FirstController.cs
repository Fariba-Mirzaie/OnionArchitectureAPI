using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Application.Services;
using OA.Domain.Entities;

namespace OnionArchitectureProject.Controllers.V1
{
    //[Route("api/[controller]")]  چرا هرچی ران میکنم v1 اجرا میشود؟
    //[Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class FirstController : ControllerBase
    {
        private readonly IProductService _productService;
        public FirstController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet]
        public string Get()
        {
            return "data from api v1";
        }

        [HttpPost("CreateProduct")]
        public IActionResult Create([FromBody]Product product)
        {
            if (_productService.CreateProduct(product))
                return Content("Done");
            else
                return BadRequest();
        }




    }
}
