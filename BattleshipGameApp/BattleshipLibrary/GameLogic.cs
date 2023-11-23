using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary.Models;

namespace BattleshipLibrary
{
    public class GameLogic
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"

            };

            List<int> numbers = new List<int> 
            { 
                1, 
                2, 
                3, 
                4, 
                5 
            };

            foreach (string letter in letters) 
            {
                foreach (int number in numbers) 
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }


        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);

        }
        public static bool PlaceShip(PlayerInfoModel playerModel, string shipLocation)
        {
            bool placeShipOutput = false;
            (string row, int column) = SplitShotIntoRowAndColumn(shipLocation);

            bool isValidShipLocation = ValidateGridLocation(playerModel, row, column);
            bool isGridSpotOpen = ValidateShipLocation(playerModel, row, column);

            if (isValidShipLocation && isGridSpotOpen)
            {
                playerModel.ShipLocations.Add(new GridSpotModel
                {
                    SpotLetter = row,
                    SpotNumber = column,
                    Status = GridSpotStatus.Ship
                });
            }

            return placeShipOutput;
        }

        private static bool ValidateShipLocation(PlayerInfoModel playerModel, string row, int column)
        {
            throw new NotImplementedException();
        }

        private static bool ValidateGridLocation(PlayerInfoModel playerModel, string row, int column)
        {
            throw new NotImplementedException();
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool playerIsStillActive = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    playerIsStillActive = true;
                }
            }

            return playerIsStillActive;
        }

        public static int GetShotCount(PlayerInfoModel player)
        {
            int playerShotCount = 0;

            foreach (var shot in player.ShotGrid) 
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    playerShotCount += 1;
                }
            }

            return playerShotCount;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            throw new NotImplementedException();
        }

        public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
        {
            throw new NotImplementedException();
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            throw new NotImplementedException();
        }

        public static void MarkShotResult(PlayerInfoModel activePlayer, string row, int column, bool isAHit)
        {
            throw new NotImplementedException();
        }
    }
}
