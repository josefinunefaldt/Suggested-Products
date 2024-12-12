using Microsoft.AspNetCore.Mvc;
namespace Product.Api.Controllers
{
    [ApiController, Route("api/vi/[controller]")]
    public class HelloController : ControllerBase
    {
        public HelloController()
        {
        }
        [HttpGet]
        public string SayHello() => "Hello";
    }
}