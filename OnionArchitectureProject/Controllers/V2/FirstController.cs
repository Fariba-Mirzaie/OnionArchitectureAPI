using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitectureProject.Controllers.V2
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet("GetVersion2")]
        public string Get()
        {
            return "data from api v2";
        }
    }
}
