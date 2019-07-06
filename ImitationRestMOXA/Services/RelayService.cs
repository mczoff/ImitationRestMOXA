using ImitationRestMOXA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImitationRestMOXA.Services
{
    public class RelayService
    {
        IList<Relay> _relays;

        public RelayService()
        {
            _relays = new List<Relay>(Enumerable.Range(0,6).Select(t => new Relay { RelayIndex = t }));
        }

        public Relay[] GetStatusRelay()
            => _relays.ToArray();

        public void SetStatusRelay(IEnumerable<Relay> relays)
        {
            _relays = relays.ToList();
        }
    }
}
