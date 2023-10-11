using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Domain.CQRS;
using OA.Domain.Entities;

namespace OnionArchitectureProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CQRSController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CQRSController(IMediator mediator) => _mediator = mediator;

        [HttpGet("/ProductList")]
        public async Task<IEnumerable<Product>> GetProductList()
        {
            return await _mediator.Send(new GetProducts.Query());
        }

        [HttpGet("/GetProduct/{id}")] 
        public async Task<Product> GetProductById([FromRoute] int id, string? name)
        {
            return await _mediator.Send(new GetProductById.Query { ProductId = id });
        }

        [HttpPost("/AddProduct")]
        public async Task<ActionResult> AddProduct([FromBody] AddProduct.Command command) //چرا int  نذاشت خروچی تسک رو
        {
            var newProductId =await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProductById), new { id = newProductId }, null);
        }

        [HttpDelete("/DeleteProduct/{productId}")]
        public async Task<IActionResult> RemoveProduct(int productId)
        {
            await _mediator.Send(new DeleteProduct.Command { Id = productId });
            return NoContent();
        }

    }
}
