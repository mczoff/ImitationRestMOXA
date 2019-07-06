using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Models
{
    public class DInputSlot
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("io")]
        public DInputIO Io { get; set; }
    }
}
