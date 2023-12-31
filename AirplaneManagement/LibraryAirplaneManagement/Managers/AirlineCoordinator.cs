using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAirplaneManagement.Managers;

namespace LibraryAirplaneManagement.Constructors
{
    public class AirlineCoordinator
    {
        FlightManager flightManager;
        CustomerManager customerManager;

        public AirlineCoordinator(int customerIdSeed, int maximumCustomers, int maximumFlights)
        {
            flightManager = new FlightManager(maximumFlights);
            customerManager = new CustomerManager(customerIdSeed, maximumCustomers);
        }

        public bool AddFLight(int flightNumber, string flightOrigin, string flightDestination, int maximumSeats)
        {
            return flightManager.AddFlight(flightNumber, flightOrigin, flightDestination, maximumSeats);
        }

        public bool AddCustomer(string customerFirstName,  string customerLastName, string customerPhoneNumber)
        {
            return customerManager.AddCustomer(customerFirstName, customerLastName, customerPhoneNumber);
        }

        public string FlightList()
        {
            return flightManager.GetFlightList();
        }

        public string CustomerList()
        {
            return customerManager.GetCustomerList();
        }

        public bool DeleteCustomer(int customerId)
        {
            return customerManager.DeleteCustomer(customerId);
        }

        public bool DeleteFlight(int flightId)
        {
            return flightManager.DeleteFlight(flightId);
        }

    }
}
