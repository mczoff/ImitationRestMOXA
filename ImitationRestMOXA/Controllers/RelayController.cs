using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ImitationRestMOXA.Models;
using ImitationRestMOXA.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ImitationRestMOXA.Controllers
{
    [ApiController]
    public class RelayController : ControllerBase
    {
        readonly RelayService _relayService;

        public RelayController(RelayService relayService)
        {
            _relayService = relayService;
        }

        [HttpGet("api/slot/0/io/relay")]
        public string Get()
        {
            var statusRelays = _relayService.GetStatusRelay();
            var statusRelaysJson = JsonConvert.SerializeObject(new RelaySlot { Slot = 0, Io = new RelayIO { Relay = statusRelays.ToList() } });

            HttpContext.Response.StatusCode = 200;

            return statusRelaysJson;
        }

        [HttpPut("api/slot/0/io/relay")]
        public void Put()
        {
            using (StreamReader stream = new StreamReader(HttpContext.Request.Body))
            {
                var statusRelaysJson = stream.ReadToEnd();
                var statusRelays = JsonConvert.DeserializeObject<RelaySlot>(statusRelaysJson);

                _relayService.SetStatusRelay(statusRelays.Io.Relay);

                HttpContext.Response.StatusCode = 200;
            }
        }
    }
}
