using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAirplaneManagement.Constructors
{
    public class Customer
    {
        public int CustomerId {  get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public int Bookings { get; private set; }

        public Customer(int customerId, string firstName, string lastName, string phoneNumber)
        {
            Bookings = 0;
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        
        public string toString()
        {
            string customerString = 
                $"Customer: {CustomerId}\nName: {LastName}, {FirstName}\nPhone: {PhoneNumber}\nBookings: {Bookings}";
            return customerString;
        }

    }
}
