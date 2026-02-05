using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController() { 
        }
        [HttpGet("get-product")]
        public IActionResult GetProduct()
        {
            return Ok("Admin Product");
        }
    }
}
