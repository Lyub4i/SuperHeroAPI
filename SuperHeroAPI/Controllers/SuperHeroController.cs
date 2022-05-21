using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : Controller
    {
        private static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id =1,
                Name = "Spider Man",
                FirstName="Peter",
                LastName="Parker",
                Place="New Yourk"
            },
            new SuperHero
            {
                Id =2,
                Name = "Iron Man",
                FirstName="Tony",
                LastName="Stark",
                Place="New York"
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return Ok(heroes);
        }
    }
}
