using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(DbContextOptions options): base(options)
        {

        }

        public DbSet<SuperHero> Heroes { get; set; }
    }
}
