using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Models
{
    public class DInputIO
    {
        [JsonProperty("di")]
        public List<DInput> DInput { get; set; }
    }
}
