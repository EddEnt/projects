using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        //Add Customer
                        break;
                    case "2":
                        //View Customer
                        break;
                    case "3":
                        //Delete Customer
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
    }
}
