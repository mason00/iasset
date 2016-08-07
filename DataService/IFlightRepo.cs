using Data;
using System.Collections.Generic;

namespace DataService
{
    public interface IFlightRepo
    {
        ICollection<Flight> GetFlights();
        Flight GetFlightByNo(string flightNo);
    }
}