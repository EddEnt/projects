using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement.Menus
{
    internal class MenuFlights
    {
        public static void FlightsMenu()
        {
            string userInput;

            Console.WriteLine();
            while (true)
            {
                Console.Clear();
                HeaderBanner.SystemHeaderBanner();

                Console.WriteLine("--- Flights Menu ---\n");

                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. View Flights");
                Console.WriteLine("3. View Individual Flight");
                Console.WriteLine("4. Delete Flight");
                Console.WriteLine("5. Back to Main Menu");

                Console.Write("Please select an option: ");

                userInput = Console.ReadLine();
                switch (userInput.Trim())
                {
                    case "1":
                        //Add Flight
                        break;
                    case "2":
                        //View Flights
                        break;
                    case "3":
                        //View Individual Flight
                        break;
                    case "4":
                        //Delete Flight
                        break;
                    case "5":
                        MenuMain.MainMenu();
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
