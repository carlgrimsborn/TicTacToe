using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameRound
    {
        GameBoard board;
        public bool player1Turn = true;
        public int numTurns = 0;

        public GameRound (GameBoard board)
        {
            this.board = board;
        }
    }
}
