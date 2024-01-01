using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAirlineManagement.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Bookings { get; set; }

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
