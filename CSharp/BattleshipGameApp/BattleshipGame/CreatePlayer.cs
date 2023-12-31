﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary;
using BattleshipLibrary.Models;

namespace BattleshipGame
{
    internal class CreatePlayer
    {
        public static PlayerInfoModel CreateNewPlayer(string playerTitle)
        {
            PlayerInfoModel playerInfoOutput = new PlayerInfoModel();
            Console.WriteLine($"Player information for { playerTitle }");

            playerInfoOutput.UserName = AskForUserName();

            GameLogic.InitializeGrid(playerInfoOutput);

            ShipPlacement(playerInfoOutput);

            Console.Clear();

            return playerInfoOutput;


        }

        public static string AskForUserName()
        {
            Console.Write("Enter your username: ");
            string usernameOutput = Console.ReadLine();

            return usernameOutput;
        }

        public static void ShipPlacement(PlayerInfoModel playerModel) 
        {
            do
            {
                Console.Write($"Where do you want to place ship {playerModel.ShipLocations.Count + 1}: ");
                string shipLocation = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(playerModel, shipLocation);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            } while (playerModel.ShipLocations.Count < 5);
        }
    }
}
