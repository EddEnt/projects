using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;
using BattleshipGame;

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

            } while (winner == null) 
            {

            }

        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Battleship console game!");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
        }
    }
}
