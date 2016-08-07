using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService
{
    public class FlightRepository : IFlightRepo
    {
        List<Flight> allFlights;

        public FlightRepository()
        {
            allFlights = new List<Flight>();
            var now = DateTime.Now;
            for (int i = 0; i < 20; i++)
            {
                allFlights.Add(new Flight() { FlightNo = i.ToString(), Arrival = now.AddMinutes(i), Depature = now.AddMinutes(29 + i) });
            }
        }

        public ICollection<Flight> GetFlights()
        {
            return allFlights;
        }

        public Flight GetFlightByNo(string flightNo)
        {
            return allFlights.FirstOrDefault(x => x.FlightNo == flightNo);
        }
    }
}
