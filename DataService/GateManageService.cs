using System.Linq;
using Data;
using System.Collections;
using System.Collections.Generic;

namespace DataService
{
    public class GateManageService : IGateManageService
    {
        IFlightRepo flightRepo;
        IGateRepo gateRepo;

        public GateManageService(IFlightRepo fRepo, IGateRepo gRepo)
        {
            flightRepo = fRepo;
            gateRepo = gRepo;

            InitialAssignment();
        }

        private void InitialAssignment()
        {
            var gate0 = gateRepo.GetGateById(0);
            var gate1 = gateRepo.GetGateById(1);

            flightRepo.GetFlights().Take(10).ToList().ForEach(x => gate0.Flights.Add(x));
            flightRepo.GetFlights().Skip(10).ToList().ForEach(x => gate1.Flights.Add(x));
        }

        public void AddFlightToGate(Flight flight, Gate gate)
        {
            gate.Flights.Add(flight);
        }

        public void RemoveFlightFromGate(Flight flight, Gate gate)
        {
            gate.Flights.Remove(flight);
        }

        public ICollection<Gate> GetGates()
        {
            return gateRepo.GetGates();
        }
        
    }
}

