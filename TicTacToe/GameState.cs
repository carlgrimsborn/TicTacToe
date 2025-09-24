using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum Winner
    {
        Undecided,
        Tie,
        Player1,
        Player2
    }
    public enum Player
    {
        Player1,
        Player2
    }

    public static class GameState
    {
        public static bool GameOver { get; set; } = false;
        public static Winner Winner { get; set; } = Winner.Undecided;
        public static Player CurrentPlayer { get; set; } = Player.Player1;

    }
}
