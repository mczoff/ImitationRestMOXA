using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Models
{
    public class RelayIO
    {
        [JsonProperty("relay")]
        public List<Relay> Relay { get; set; }
    }
}
