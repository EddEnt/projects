using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary;
using BattleshipLibrary.Models;

namespace BattleshipGame
{
    internal class PlayerShots
    {

        internal static void RecordPlayerShots(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {                    
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }

            } while (isValidShot == false);

            //Determine shot results
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            //Recording Results
            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
            DisplayShotResults(row, column, isAHit);

        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{row}{column} is a hit!"); 
            }
            else
            {
                Console.WriteLine($"{row}{column} is a miss.");
            }
            Console.WriteLine();
        }

        private static string AskForShot(PlayerInfoModel player )
        {
            Console.WriteLine($"{ player.UserName }, please enter your shot selection: ");
            string userEnteredShotOutput = Console.ReadLine();

            return userEnteredShotOutput;
        }
    }
}
