using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class Menu
    {

        public static void MainMenu()
        {
            WelcomeMessage();

            PlayerInfoModel player1 = CreatePlayer.CreateNewPlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer.CreateNewPlayer("Player 2");

        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Battleship console game!");
            Console.WriteLine("Built by Edward Entecott");
            Console.WriteLine();
        }
    }
}
