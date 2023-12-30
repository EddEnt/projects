using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneManagement;

namespace AirplaneManagement.Menus
{
    internal class Menu
    {
        public static void MainMenu()
        {
            string userInput = string.Empty;

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
                        Customers.CustomersMenu();
                        break;
                    case "2":
                        //Flight Selection
                        break;
                    case "3":
                        //Bookings Selection
                        break;
                    case "4":
                        Console.WriteLine("Now exiting. Goodbye...");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Unknown input. Please try again...");
                        break;
                }
            }
        }
    }
}
