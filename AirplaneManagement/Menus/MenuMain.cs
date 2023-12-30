using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneManagement;

namespace AirplaneManagement.Menus
{
    internal class MenuMain
    {
        public static void MainMenu()
        {
            string userInput = string.Empty;

            Console.WriteLine();
            while (true) {

                Console.Clear();
                HeaderBanner.SystemHeaderBanner();

                Console.WriteLine("--- Welcome to the Airplane Management System ---\n");

                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Flights");
                Console.WriteLine("3. Bookings");
                Console.WriteLine("4. Exit");

                Console.Write("Please select an option: ");

                userInput = Console.ReadLine();
                switch (userInput.Trim())
                {
                    case "1":
                        MenuCustomers.CustomersMenu();
                        break;
                    case "2":
                        MenuFlights.FlightsMenu();
                        break;
                    case "3":
                        MenuBookings.BookingsMenu();
                        break;
                    case "4":
                        Console.WriteLine("Now exiting. Goodbye...");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Unknown input. Please try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
