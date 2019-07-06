using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ImitationRestMOXA.Models
{
    [JsonObject("relay")]
    public class Relay
    {
        [JsonProperty("relayIndex")]
        public int RelayIndex { get; set; }
        [JsonProperty("relayMode")]
        public int RelayMode { get; set; }
        [JsonProperty("relayStatus")]
        public int RelayStatus { get; set; }
        [JsonProperty("relayTotalCount")]
        public int RelayTotalCount { get; set; }
        [JsonProperty("relayCurrentCount")]
        public int RelayCurrentCount { get; set; }
        [JsonProperty("relayCurrentCountReset")]
        public int RelayCurrentCountReset { get; set; }
    }
}
