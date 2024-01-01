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

        public static void AddFlight()
        {
            int flightNumber, maxNumberOfSeats;
            string flightOrigin, flightDestination;

            Console.Clear();
            Console.WriteLine("--- Add Flight ---\n");
            Console.Write("Please enter the flight number: ");
            flightNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the flight origin: ");
            flightOrigin = Console.ReadLine();

            Console.Write("Please enter the flight destination: ");
            flightDestination = Console.ReadLine();

            Console.Write("Please enter the maximum number of seats: ");
            maxNumberOfSeats = Convert.ToInt32(Console.ReadLine());

            if(Program.aCoord.AddFlight(flightNumber, flightOrigin, flightDestination, maxNumberOfSeats))
            {
                Console.WriteLine("Flight added successfully!");
            }
            else
            {
                Console.WriteLine("Flight could not be added. Please try again...");
            }
            Console.WriteLine("Press any key to return to the Flight Menu...");
            Console.ReadKey();
        }

        public static void ViewFlights()
        {
            Console.Clear();
            Console.WriteLine("--- Flight List---\n");
            Console.WriteLine(Program.aCoord.FlightList());

            Console.WriteLine("Press any key to return to the Flight Menu...");
            Console.ReadKey();
        }

        public static void ViewIndividualFlight()
        {
            int flightNumber;

            Console.Clear();
            Console.WriteLine("--- View Individual Flight ---\n");
            Console.Write("Please enter the flight number: ");
            flightNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Program.aCoord.GetFlight(flightNumber));

            Console.WriteLine("Press any key to return to the Flight Menu...");
            Console.ReadKey();
        }

    }
}
