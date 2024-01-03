using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using LibraryMathGame.Games;
using LibraryMathGame;

namespace MathGame
{
    public class Menu
    {

        private static string username = string.Empty;

        public static void GameMenu()
        {
            bool askForUsername = true;

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------");
                Console.WriteLine("Welcome to the Math Game App!");

                if (askForUsername)
                {
                    Console.Write("To start, what is your name?: ");
                    GetUsername();
                    askForUsername = false;
                }

                Console.WriteLine($"Welcome, {username}, please select an option from the list below: ");

                Console.WriteLine("\nA - Addition Game");
                Console.WriteLine("S - Subtraction Game");
                Console.WriteLine("M - Multiplication Game");
                Console.WriteLine("D - Division Game");
                Console.WriteLine("V - View Past Game Sessions");
                Console.WriteLine("Q - Quit");
                Console.Write("Option: ");

                string inputSelection = Console.ReadLine();
                switch (inputSelection.Trim().ToLower())
                {
                    case "a":
                        AdditionGame.StartAdditionGame();
                        break;
                    case "s":
                        SubtractionGame.StartSubtractionGame();
                        break;
                    case "m":
                        MultiplicationGame.StartMultiplicationGame();
                        break;
                    case "d":
                        DivisionGame.StartDivisionGame();
                        break;
                    case "v":
                        PastGameSessions.ViewPastGameSessions();
                        break;
                    case "q":
                        Console.WriteLine("Exiting the game. Goodbye...");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }

        public static void GetUsername()
        {
            username = Console.ReadLine();
        }


    }
}
