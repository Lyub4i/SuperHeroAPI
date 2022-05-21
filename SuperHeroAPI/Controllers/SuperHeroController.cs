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

        [HttpGet ("{id}")] //указуй у дужках, бо не буде пахати інакше!
        public async Task<ActionResult<SuperHero>> Get(int id)
        {
            var hero = heroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return BadRequest($"Not hero with {id}");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            heroes.Add(hero);
            return Ok(heroes);
        }
    }
}
