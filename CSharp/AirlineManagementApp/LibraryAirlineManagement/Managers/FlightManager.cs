using LibraryAirlineManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAirlineManagement.Managers
{
    public class FlightManager
    {

        private int maximumFlights;
        private int numberOfFlights;
        private Flight[] flightList;

        public FlightManager(int maximum)
        {
            maximumFlights = maximum;
            numberOfFlights = 0;
            flightList = new Flight[maximumFlights];
        }

        public bool AddFlight(int flightNumber, string origin, string destination, int maxSeats)
        {
            if (numberOfFlights >= maximumFlights) { return false; }
            Flight f = new Flight(flightNumber, origin, destination, maxSeats);
            numberOfFlights++;
            return true;
        }

        public int FindFlight(int flightId)
        {
            for (int i = 0; i < numberOfFlights; i++)
            {
                if (flightList[i].FlightNumber == flightId)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool FlightExists(int flightId)
        {
            int location = FindFlight(flightId);
            if (location == -1) { return false; }
            return true;
        }

        public Flight GetFlight(int flightId)
        {
            int location = FindFlight(flightId);
            if (location == -1) { return null; }
            return flightList[location];
        }

        public bool DeleteFlight(int flightId)
        {
            int location = FindFlight(flightId);
            if (location == -1) { return false; }
            flightList[location] = flightList[location - 1];
            numberOfFlights--;
            return true;
        }

        public string GetFlightList()
        {
            string flightString = "Flight List: ";
            for (int i = 0; i < numberOfFlights; i++)
            {
                flightString += $"\n{flightList[i].FlightNumber} from {flightList[i].FlightOrigin} to {flightList[i].FlightDestination}";
            }
            return flightString;
        }

    }
}
