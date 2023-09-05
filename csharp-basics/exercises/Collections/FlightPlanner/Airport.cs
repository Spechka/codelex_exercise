using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    internal class Airport
    {
        private string _airportName;
        private List<Airport> _availableDestinations = new List<Airport>();

        public Airport(string airportName)
        {
            _airportName = airportName;
        }

        public void AddDestination(Airport destination)
        {
            _availableDestinations.Add(destination);
        }

        public void DisplayDestinations()
        {
            int counter = 1;
            Console.WriteLine($"--- Available destinations from :: {_airportName}! ---");
            foreach (var port in _availableDestinations)
            {
                Console.WriteLine($" {counter}.| {port.AirportName}");
                counter++;
            }

            Console.WriteLine();
        }

        public string AirportName => _airportName;
    }
}
