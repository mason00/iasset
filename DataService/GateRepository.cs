using Data;
using System.Collections.Generic;
using System.Linq;

namespace DataService
{
    public class GateRepository : IGateRepo
    {
        List<Gate> allGate;

        public GateRepository()
        {
            allGate = new List<Gate>();
            for (int i = 0; i < 2; i++)
            {
                allGate.Add(new Gate() { GateNumber = i });
            }
        }

        public Gate GetGateById(int gateNumber)
        {
            return allGate.FirstOrDefault(g => g.GateNumber == gateNumber);
        }

        public ICollection<Gate> GetGates()
        {
            return allGate;
        }
    }
}
