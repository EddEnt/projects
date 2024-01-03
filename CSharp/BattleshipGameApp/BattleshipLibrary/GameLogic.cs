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
        public static void InitializeGrid(PlayerInfoModel playerModel)
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
                    AddGridSpot(playerModel, letter, number);
                }
            }
        }


        private static void AddGridSpot(PlayerInfoModel playerModel, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            playerModel.ShotGrid.Add(spot);

        }
        //Ship location validation for PlaceShip method
        private static bool ValidateShipLocation(PlayerInfoModel playerModel, string row, int column)
        {
            bool isValidShipLocation = true;

            foreach (var ship in playerModel.ShipLocations) 
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidShipLocation = false;
                }
            }

            return isValidShipLocation;
        }

        //Grid location validation for PlaceShip method
        private static bool ValidateGridLocation(PlayerInfoModel playerModel, string row, int column)
        {
            bool isValidGridLocation = false;

            foreach (var ship in playerModel.ShotGrid)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidGridLocation = true;
                }
            }

            return isValidGridLocation;
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
                    SpotLetter = row.ToUpper(),
                    SpotNumber = column,
                    Status = GridSpotStatus.Ship
                });

                placeShipOutput = true;
            }

            return placeShipOutput;
        }

        public static bool PlayerStillActive(PlayerInfoModel activePlayer)
        {
            bool playerIsStillActive = false;

            foreach (var ship in activePlayer.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    playerIsStillActive = true;
                }
            }

            return playerIsStillActive;
        }

        public static int GetShotCount(PlayerInfoModel playerModel)
        {
            int playerShotCount = 0;

            foreach (var shot in playerModel.ShotGrid) 
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    playerShotCount += 1;
                }
            }

            return playerShotCount;
        }

        //Places the shot into the correct row and column
        //Splits the string(representing a shot) into its row and column components
        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            string row = "";
            int column = 0;

            if (shot.Length != 2)
            {
                throw new ArgumentException("This was an invalid shot type. ", "shot");
            }

            char[] shotArray = shot.ToArray();

            row = shotArray[0].ToString();
            column = int.Parse(shotArray[1].ToString());

            return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel playerModel, string row, int column)
        {
            bool isValidShot = false;

            foreach (var gridSpot in playerModel.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (gridSpot.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }

            return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            bool isAHitOnShip = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column) 
                {
                    isAHitOnShip = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }

            return isAHitOnShip;
        }

        public static void MarkShotResult(PlayerInfoModel playerModel, string row, int column, bool isAHit)
        {
            bool isValidGridLocation = true;

            foreach (var gridSpot in playerModel.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column) 
                {
                    if(isAHit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
