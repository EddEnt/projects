using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAirlineManagement.Models;

namespace LibraryAirlineManagement.Managers
{
    public class CustomerManager
    {
        public static int currentCustomerNumber;
        private int maxNumberOfCustomers;
        private int numberOfCustomers;
        private Customer[] customerList;

        public CustomerManager(int ccn, int max)
        {
            currentCustomerNumber = ccn;
            maxNumberOfCustomers = max;
            numberOfCustomers = 0;
            customerList = new Customer[maxNumberOfCustomers];
        }

        public bool AddCustomer(string firstName, string lastName, string phoneNumber)
        {
            if (numberOfCustomers >= maxNumberOfCustomers) { return false; }
            Customer c = new Customer(currentCustomerNumber, firstName, lastName, phoneNumber);
            currentCustomerNumber++;
            customerList[numberOfCustomers] = c;
            numberOfCustomers++;
            return true;
        }

        public int FindCustomer(int cid)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                if (customerList[i].CustomerId == cid)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool CustomerExists(int customerId)
        {
            int location = FindCustomer(customerId);
            if (location == -1) { return false; }
            return true;
        }

        public Customer GetCustomer(int customerId)
        {
            int location = FindCustomer(customerId);
            if (location == -1) { return null; }
            return customerList[location];
        }

        public bool DeleteCustomer(int customerId)
        {
            int location = FindCustomer(customerId);
            if (location == -1) { return false; }
            customerList[location] = customerList[numberOfCustomers - 1];
            numberOfCustomers--;
            return true;
        }

        public string GetCustomerList()
        {
            string customerString = $"Customer List: \nNumber \tName \tPhone";
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customerString += $"\n{customerList[i].CustomerId} \t{customerList[i].LastName}, {customerList[i].FirstName} \t{customerList[i].PhoneNumber}";
            }
            return customerString;
        }

    }
}
