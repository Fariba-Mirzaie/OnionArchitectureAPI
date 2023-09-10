using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitectureProject.Controllers.V1
{
    //[Route("api/[controller]")]  چرا هرچی ران میکنم v1 اجرا میشود؟
    //[Route("api/v{version:apiVersion}/[controller]")]

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "data from api v1";
        }
    }
}
