using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreApiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class HealthcheckController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
