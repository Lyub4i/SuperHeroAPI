using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options): base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
