using BattleshipLibrary;
using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class PlayerShots
    {
        internal static void RecordPlayerShots(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool doesGameContinue = GameLogic.PlayerStillActive(opponent);
        }
    }
}
