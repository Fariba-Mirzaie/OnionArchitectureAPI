using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitectureProject.Controllers
{
    [Route("api/v{version:apiVersion}[controller]")]
    [ApiController]
    public class SecondController : ControllerBase
    {
        [ApiVersion("2")]
        public string show()
        {
            return "Show v2";
        }
    }

}
//namespace OnionArchitectureProject.Controllers
//{
//    [Route("api/v{version:apiVersion}[controller]")]
//        [ApiVersion("2.1")]
//        public string show()
//        {
//            return "Show v2.1";
//        }

//}
//????