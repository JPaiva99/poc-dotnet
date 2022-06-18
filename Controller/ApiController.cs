using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet("gerarNumero")]
        public async Task<ActionResult<int>> GenerateNumber([FromQuery]int min, int max)
        {
            var randomGenerator = new Random();
            return Ok(randomGenerator.Next(min, max));
        }
    }
}

