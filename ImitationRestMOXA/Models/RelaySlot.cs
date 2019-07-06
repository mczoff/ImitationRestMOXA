using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Models
{
    public class RelaySlot
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("io")]
        public RelayIO Io { get; set; }
    }
}
