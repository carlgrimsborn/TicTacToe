using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class State
    {
        public static bool Player1Turn { get; set; } = true;
        public static int NumTurns { get; set; } = 0;
        public static bool GameRunning { get; set; } = true;
        
        // not used
        public static void ResetGame()
        {
            Player1Turn = true;
            NumTurns = 0;
        }
    }
}
