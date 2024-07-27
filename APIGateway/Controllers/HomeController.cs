using Microsoft.AspNetCore.Mvc;

namespace APIGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public async Task<ActionResult> Index()
        {
            return await Task.FromResult<ActionResult>(Ok("Hello"));
        }
    }
}
