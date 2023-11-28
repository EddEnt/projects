using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMathGame.GameSettings
{
    internal class Difficulty
    {
        internal static string GetDifficultyLevel()
        {
            Console.Write("Select the difficulty level (Easy, Regular, or Hard): ");
            string difficulty = Console.ReadLine().Trim().ToLower();

            if (difficulty == "easy" || difficulty == "regular" || difficulty == "hard")
            {
                return difficulty;
            }
            else if (difficulty == "q")
            {
                Console.WriteLine("Returning to the main menu.");
                return null;
            }
            else
            {
                Console.WriteLine("Invalid difficulty level. Please try again.");
                return GetDifficultyLevel();
            }
        }

        internal static void SetDifficultyRange(string difficulty, out int min, out int max)
        {
            switch (difficulty)
            {
                case "easy":
                    min = 1;
                    max = 10;
                    break;
                case "regular":
                    min = 1;
                    max = 100;
                    break;
                case "hard":
                    min = 1;
                    max = 1000;
                    break;
                default:
                    min = 0;
                    max = 0;
                    break;
            }
        }

    }
}
