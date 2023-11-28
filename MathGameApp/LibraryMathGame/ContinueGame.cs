using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame
{
    internal class ContinueGame
    {
        internal static bool AskToContinueGame()
        {
            while (true)
            {
                Console.Write("Do you want to play again? (yes/no) ");
                string inputContinueQuestionGame = Console.ReadLine().Trim().ToLower();

                if (inputContinueQuestionGame == "yes")
                {
                    return true; // Continue game
                }
                else if (inputContinueQuestionGame == "no")
                {
                    Console.WriteLine("Returning to the main menu.");
                    return false; // Exit addition game
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }

        }
    }
}
