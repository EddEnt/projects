using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary.Models
{
    internal class PlayerInfroModel
    {
        public string UserName { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; }
        public List<GridSpotModel> ShotGrid {  get; set; }
    }
}
