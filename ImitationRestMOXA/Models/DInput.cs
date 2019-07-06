using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Models
{
    public class DInput
    {
        [JsonProperty("diIndex")]
        public int DIIndex { get; set; }
        [JsonProperty("diMode")]
        public int DIMode { get; set; }
        [JsonProperty("diStatus")]
        public int DIStatus { get; set; }
    }
}
