using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class ApplactionContextDb : DbContext
    {
        public ApplactionContextDb(DbContextOptions options): base(options)
        {

        }

        public DbSet<SuperHero> Heroes { get; set; }
    }
}
