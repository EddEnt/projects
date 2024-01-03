using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HabitTrackerLibrary;

namespace HabitTracker
{
    internal class Menu
    {
        public static void MainMenu()
        {

            Console.Clear();
            while (true)
            {
                Console.WriteLine("\nCRUD Options Program");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 - View Records");
                Console.WriteLine("2 - Insert Record");
                Console.WriteLine("3 - Delete Record");
                Console.WriteLine("4 - Update Record");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("-------------------------");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        databaseMethods.DBViewAllRecords();

                        break;
                    case "2":
                        databaseMethods.DBInsertRecord();
                        break;
                    case "3":
                        databaseMethods.DBDeleteRecord();
                        break;
                    case "4":
                        // UpdateRecord();
                        break;
                    case "q":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Unknown entry. Please enter another option...\n");
                        break;

                }

            }
        }
    }
       
}


