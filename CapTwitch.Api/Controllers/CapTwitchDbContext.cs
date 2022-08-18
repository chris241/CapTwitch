using CapTwitch.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CapTwitch.Api.Controllers
{
    public class CaptTwitchDbContext : DbContext
    {
        public DbSet<SteamEvent> SteamEvents { get; set; }

        public CaptTwitchDbContext(DbContextOptions<CaptTwitchDbContext> ctx) : base(ctx)
        {

        }
    }
}
