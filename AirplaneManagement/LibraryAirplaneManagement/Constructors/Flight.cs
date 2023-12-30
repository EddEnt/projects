using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAirplaneManagement.Constructors
{
    public class Flight
    {
        public int FlightNumber {  get; private set; }
        public string FlightOrigin { get; private set; }
        public string FlightDestination {  get; private set; }
        public int MaxNumberOfSeats { get; private set; }
        public int NumberOfPassengers {  get; private set; }
        public Customer[] Passengers { get; private set; }

        public Flight(int flightNumber, string flightOrigin, string flightDestination, int maxNumberOfSeats, int numberOfPassengers, Customer[] passengers)
        {
            FlightNumber = flightNumber;
            FlightOrigin = flightOrigin;
            FlightDestination = flightDestination;
            MaxNumberOfSeats = maxNumberOfSeats;
            NumberOfPassengers = 0;
            Passengers = new Customer[MaxNumberOfSeats];
        }

        public bool AddPassenger(Customer customer)
        {
            if(NumberOfPassengers >= MaxNumberOfSeats)
            {
                return false;
            }
            Passengers[NumberOfPassengers] = customer;
            NumberOfPassengers++;
            return true;

        }

        public int FindPassenger(int customerID)
        {
            for(int i = 0; i < MaxNumberOfSeats; i++)
            {
                if (Passengers[i].CustomerId == customerID)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool RemovePassenger(int customerID)
        {
            int location = FindPassenger(customerID);
            if(location == -1)
            {
                return false;
            }

            Passengers[location] = Passengers[NumberOfPassengers - 1];
            NumberOfPassengers--;
            return true;
        }

        public string GetPassengerList()
        {
            string passengerList = $"\nPassengers on flight {FlightNumber}:";
            for (int i = 0; i < NumberOfPassengers;  i++)
            {
                passengerList = passengerList + "\n" + Passengers[i].LastName + ", " + Passengers[i].FirstName;
            }
            return passengerList;
        }

        public string toString()
        {
            string flightString = $"Flight Number: {FlightNumber}\nOrigin: {FlightOrigin}\nDestination: {FlightDestination}\nNumber of Passengers: {NumberOfPassengers}\nAvailable Seats: {MaxNumberOfSeats - NumberOfPassengers}";
            flightString = flightString + GetPassengerList();
            return flightString;
        }

    }
}
