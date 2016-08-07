using Data;
using System.Collections.Generic;

namespace DataService
{
    public interface IGateRepo
    {
        Gate GetGateById(int gateNumber);
        ICollection<Gate> GetGates();
    }
}