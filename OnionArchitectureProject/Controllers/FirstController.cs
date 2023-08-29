using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitectureProject.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    
    public class FirstController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Version 1.0");
        }

        //[HttpGet, MapToApiVersion("2.0")]
        //public IActionResult GetV2()
        //{
        //    return Ok("Version 2.0");
        //}

    }
}
