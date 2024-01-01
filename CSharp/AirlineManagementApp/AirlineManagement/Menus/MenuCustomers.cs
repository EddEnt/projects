using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAirlineManagement;
using LibraryAirlineManagement.Managers;

namespace AirlineManagement.Menus
{

    internal class MenuCustomers
    {

        public static void CustomersMenu()
        {
            string userInput;

            Console.WriteLine();
            while (true)
            {
                Console.Clear();
                HeaderBanner.SystemHeaderBanner();

                Console.WriteLine("--- Customer Menu ---\n");

                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customer");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Back to Main Menu");

                Console.Write("Please select an option: ");

                userInput = Console.ReadLine();
                switch (userInput.Trim())
                {
                    case "1":
                        AddCustomer();
                        break;
                    case "2":
                        ViewCustomer();
                        break;
                    case "3":
                        DeleteCustomer();
                        break;
                    case "4":
                        MenuMain.MainMenu();
                        break;
                    default:
                        Console.WriteLine("Unknown input. Please try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void AddCustomer()
        {

            string firstName, lastName, phoneNumber;

            Console.Clear();
            Console.WriteLine("--- Add Customer ---\n");

            Console.Write("Customer First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Customer Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Customer Phone Number: ");
            phoneNumber = Console.ReadLine();
            if (Program.aCoord.AddCustomer(firstName, lastName, phoneNumber))
            {
                Console.WriteLine("Customer added successfully.");
            }
            else
            {
                Console.WriteLine("Customer not added.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public static void ViewCustomer()
        {
            Console.Clear();
            Console.WriteLine(Program.aCoord.CustomerList());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void DeleteCustomer()
        {
            int customerId;

            Console.Clear();
            Console.WriteLine(Program.aCoord.CustomerList());

            Console.Write("Please enter the Customer ID number to delete: ");
            customerId = Convert.ToInt32(Console.ReadLine());

            if(Program.aCoord.DeleteCustomer(customerId))
            {
                Console.WriteLine($"Customer {customerId} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Customer {customerId} was not found...");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }


    }
}
