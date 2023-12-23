using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWhitespaceRemoval;

namespace WhitespaceRemoverApp
{
    internal class Menu
    {
        public static void MainMenu()
        {         
            while (true)
            {

                Console.WriteLine("Please make a selection from the list below:");

                Console.WriteLine("1. Whitespace Remover");
                Console.WriteLine("2. History");
                Console.WriteLine("3. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        WhitespaceRemoval.RemoveWhitespaceFromString();                      
                        break;
                    case "2":
                        //View History
                        Console.WriteLine("History");
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again");
                        break;


                }
            }
        }
    }
}
