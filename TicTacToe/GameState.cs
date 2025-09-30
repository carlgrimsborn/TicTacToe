using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class GameState
    {
        public static bool HasPrintedWelcomeMessage { get; set; } = false;
        public static bool Player1Turn { get; set; } = true;
        public static int NumTurns { get; set; } = 0;

        public static bool ShouldGameKeepRunning(string[] board)
        {
            return !GameActions.DidPlayerWin(board) && NumTurns != 9;
        }
    }
}
