using System.Collections.Generic;

namespace Data
{
    public class Gate
    {
        public Gate()
        {
            Flights = new List<Flight>();
        }

        public int GateNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }
}
