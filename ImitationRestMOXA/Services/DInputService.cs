using ImitationRestMOXA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Services
{
    public class DInputService
    {
        IList<DInput> _dinputs;

        public DInputService()
        {
            _dinputs = new List<DInput>(Enumerable.Range(0, 6).Select(t => new DInput { DIIndex = t }));
        }

        public DInput[] GetStatusRelay()
            => _dinputs.ToArray();

        public void SetStatusRelay(IEnumerable<DInput> dInputs)
        {
            _dinputs = dInputs.ToList();
        }
    }
}
