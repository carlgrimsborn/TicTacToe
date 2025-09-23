using System;
using System.Collections.Generic;
using System.Linq;
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
    public static class GameState
    {
        public static bool GameOver { get; set; } = false;
        public static Winner Winner { get; set; } = Winner.Undecided;

        public static void CalculateWinCondition(List<Cell> cells)
        {

            string[] winConditions = { "123", "456", "789", "741", "852", "963", "159", "753" };

            var markedPlayer1Cells = cells.FindAll(cell => findMarked(cell, CellOwner.Player1));
            var markedPlayer2Cells = cells.FindAll(cell => findMarked(cell, CellOwner.Player2));

            foreach (string winCondition in winConditions)
            {
                int matchesPlayer1 = 0;
                int matchesPlayer2 = 0;

                foreach (char victoryNumber in winCondition)
                {
                    int victoryNumberAsInt = victoryNumber - '0';
                    bool p1Match = markedPlayer1Cells.Find(cell => cell.CellValue == victoryNumberAsInt) != null;
                    bool p2Match = markedPlayer2Cells.Find(cell => cell.CellValue == victoryNumberAsInt) != null;
                    if (p1Match)
                    {
                        matchesPlayer1 += 1;
                    }
                    if (p2Match)
                    {
                        matchesPlayer2 += 1;
                    }
                }

                if (matchesPlayer1 == 3)
                {
                    GameState.Winner = Winner.Player1;
                    GameState.GameOver = true;
                    return;
                }
                if (matchesPlayer2 == 3)
                {
                    GameState.Winner = Winner.Player2;
                    GameState.GameOver = true;
                    return;
                }
            }

            if (cells.Find(cell => cell.Owner == CellOwner.Undecided) == null && GameState.Winner == Winner.Undecided)
            {
                GameState.Winner = Winner.Tie;
                GameState.GameOver = true;
            }

        }

        static bool findMarked(Cell cell, CellOwner searchVariant)
        {
            if (cell.Owner == searchVariant)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
