using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneManagement.Menus
{
    internal class MenuBookings
    {
        public static void BookingsMenu()
        {
            string userInput = string.Empty;

            while (true)
            {
                Console.Clear();

                HeaderBanner.SystemHeaderBanner();
                Console.WriteLine("--- Bookings Menu ---\n");

                Console.WriteLine("1. Add Booking");
                Console.WriteLine("2. View Booking");
                Console.WriteLine("3. Back to Main Menu");

                Console.Write("Please select an option: ");

                userInput = Console.ReadLine();
                switch (userInput.Trim())
                {
                    case "1":
                        //Add Booking
                        break;
                    case "2":
                        //View Booking
                        break;
                    case "3":
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
