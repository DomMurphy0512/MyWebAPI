using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var name = new { Name = "Domenic Murphy" };
            return Ok(name);
        }
    }
}
