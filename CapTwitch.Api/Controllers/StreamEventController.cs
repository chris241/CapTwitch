using CapTwitch.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapTwitch.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
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
        public SteamEvent Post([FromBody] SteamEvent se)  
        {
            _ctx.SteamEvents.Add(se);
            _ctx.SaveChanges();
            return se;
        }

    }
}
