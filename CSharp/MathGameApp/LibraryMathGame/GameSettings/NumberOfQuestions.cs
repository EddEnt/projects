using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame.GameSettings
{
    internal class NumberOfQuestions
    {
        internal static int GetNumberOfQuestions()
        {
            Console.Write("Enter the number of questions to play: ");
            if (int.TryParse(Console.ReadLine(), out int questions))
            {
                return questions;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return GetNumberOfQuestions();
            }
        }
    }
}
