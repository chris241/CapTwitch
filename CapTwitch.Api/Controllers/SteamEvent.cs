using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CapTwitch.Api.Controllers
{
    public class SteamEvent
    {
        public int Id { get; set;   }
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime Date { get; set; }
        public string Background { get; set; }
        public string Tecs { get; set; }

    }
    [Route("[controller]")]
    public class StreamEventController : ControllerBase
    {
        private CaptTwitchDbContext _ctx;
        public StreamEventController(CaptTwitchDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet]
        public List<SteamEvent> All()
        {
            return _ctx.SteamEvents.ToList();
        }
        [HttpPost]
        public SteamEvent Post([FromBody]SteamEvent se)
        {
            return se;
        }

    }
    public class CaptTwitchDbContext : DbContext
    {
        public DbSet<SteamEvent> SteamEvents { get; set; }  

        public CaptTwitchDbContext(DbContextOptions<CaptTwitchDbContext> ctx): base(ctx)
        {

        }
    }
}
