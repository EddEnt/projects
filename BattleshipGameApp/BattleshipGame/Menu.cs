using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;
using BattleshipGame;
using BattleshipLibrary;

namespace BattleshipGame
{
    internal class Menu
    {

        public static void MainMenu()
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer.CreateNewPlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer.CreateNewPlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                ShotGridUI.DisplayShotGrid(activePlayer);
                PlayerShots.RecordPlayerShots(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue == true)
                {
                    //Tuple usage to swap player positions
                    (activePlayer, opponent) = (opponent, activePlayer);

                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to { winner.UserName}. You are the winner!");
            Console.WriteLine($" { winner.UserName } took { GameLogic.GetShotCount(winner) } shots.");
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Battleship console game!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }
    }
}
