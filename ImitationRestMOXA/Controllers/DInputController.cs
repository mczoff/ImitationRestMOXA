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
    public class DInputController : ControllerBase
    {
        readonly DInputService _dInputService;

        public DInputController(DInputService relayService)
        {
            _dInputService = relayService;
        }

        [HttpGet("api/slot/0/io/di")]
        public string Get()
        {
            var statusDInputs = _dInputService.GetStatusRelay();
            var statusDInputsJson = JsonConvert.SerializeObject(new DInputSlot { Slot = 0, Io = new DInputIO { DInput = statusDInputs.ToList() } });

            HttpContext.Response.StatusCode = 200;

            return statusDInputsJson;
        }

        [HttpPut("api/slot/0/io/di")]
        public void Put()
        {
            using (StreamReader stream = new StreamReader(HttpContext.Request.Body))
            {
                var statusDInputsJson = stream.ReadToEnd();
                var statusDInputs = JsonConvert.DeserializeObject<DInputSlot>(statusDInputsJson);

                _dInputService.SetStatusRelay(statusDInputs.Io.DInput);

                HttpContext.Response.StatusCode = 200;
            }
        }
    }
}
