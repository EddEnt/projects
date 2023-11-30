using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHabitTracker.API
{
    public class Create
    {

        public static void InsertRecord()
        {
            string date = GetDateInput();
        }

        internal static string GetDateInput()
        {
            Console.WriteLine("Please enter the current date: (dd-mm-yy). Enter '0' to return to the Main Menu... ");
            string dateInput = Console.ReadLine();

            if (dateInput == "0")
            {
                //GetUserInput();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again...");
            }

            return dateInput;

        }

        //internal static int GetNumberInput(string message)
        //{
        //    Console.WriteLine(message);
        //    string numberInput = Console.ReadLine();

        //    if (numberInput == "0")
        //    {

        //    }
        //}

    }


}
