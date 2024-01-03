using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HabitTrackerLibrary.API
{
    public class Create
    {

        public static void InsertRecord()
        {
            string date = GetDateInput();

            int waterQuantity = GetNumberInput("\nPlease insert the number of glasses or other measurment (No decimals allowed!)\n");

            
        }

        internal static string GetDateInput()
        {
            Console.WriteLine("Please enter the current date: (dd-mm-yy). Enter '0' to return to the Main Menu... ");
            string dateInput = Console.ReadLine();

            if (dateInput == "0")
            {
                //GetUserInput();
                return null;
            }
            else
            {
                Console.WriteLine("Entry success!");
            }

            return dateInput;
            
        }

        internal static int GetNumberInput(string message)
        {
            Console.WriteLine(message);
            string numberInput = Console.ReadLine();
            
            if (numberInput == "0") return 0;

            int finalInput = Convert.ToInt32(numberInput);            
            return finalInput;
        }

    }


}
