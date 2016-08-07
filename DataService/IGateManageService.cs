using Data;
using System.Collections.Generic;

namespace DataService
{
    public interface IGateManageService
    {
        void AddFlightToGate(Flight flight, Gate gate);
        void RemoveFlightFromGate(Flight flight, Gate gate);
        ICollection<Gate> GetGates();
    }
}