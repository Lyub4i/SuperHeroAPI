using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero{ }
            }
        }
    }
}
