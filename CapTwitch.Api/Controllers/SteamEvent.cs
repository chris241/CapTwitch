﻿using Microsoft.AspNetCore.Mvc;

namespace CapTwitch.Api.Controllers
{
    public class SteamEvent
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime Date { get; set; }
        public string Background { get; set; }
        public string Tecs { get; set; }

    }
    [Route("[controller]")]
    public class StreamEventController : ControllerBase
    {
        [HttpGet]
        public string Hi()
        {
            return "Hello";
        }

    }
}
