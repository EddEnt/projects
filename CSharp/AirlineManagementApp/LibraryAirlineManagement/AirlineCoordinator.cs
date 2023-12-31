﻿using LibraryAirlineManagement.Managers;

namespace LibraryAirlineManagement
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

            public bool AddFlight(int flightNumber, string flightOrigin, string flightDestination, int maximumSeats)
            {
                return flightManager.AddFlight(flightNumber, flightOrigin, flightDestination, maximumSeats);
            }

            public bool AddCustomer(string customerFirstName, string customerLastName, string customerPhoneNumber)
            {
                return customerManager.AddCustomer(customerFirstName, customerLastName, customerPhoneNumber);
            }

            public string FlightList()
            {
                return flightManager.GetFlightList();
            }

            public int GetFlight(int flightId)
        {
                return flightManager.FindFlight(flightId);
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
