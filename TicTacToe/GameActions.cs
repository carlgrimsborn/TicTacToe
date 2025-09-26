using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class GameActions
    {
        public static void RunGame(List<Cell> cells)
        {
            while (GameState.GameOver == false)
            {
                PrintBoard(cells);
                UserInput(cells);
                CalculateWinCondition(cells);
                Console.Clear();
            }
            if (GameState.GameOver)
            {
                PrintBoard(cells);
                if (GameState.Winner == Winner.Tie)
                {
                    Console.WriteLine("\nIt is a tie!");
                    return;
                }
                else
                {
                    Console.WriteLine("\nThe winner is {0}", GameState.Winner);
                    return;
                }
            }
        }

        private static void CalculateWinCondition(List<Cell> cells)
        {

            string[] winConditions = { "123", "456", "789", "741", "852", "963", "159", "753" };

            // find marked cells for each player
            List<Cell> markedPlayer1Cells = cells.FindAll(cell => cell.Owner == CellOwner.Player1);
            List<Cell> markedPlayer2Cells = cells.FindAll(cell => cell.Owner == CellOwner.Player2);

            // check if the players has picked one of the right combinations in winConditions
            foreach (string winCondition in winConditions)
            {
                int matchesPlayer1 = 0;
                int matchesPlayer2 = 0;

                // loop through each winCondition to see if the players has it
                foreach (char winNumber in winCondition)
                {
                    int winNumberAsInt = winNumber - '0';

                    // check if the marked cells for each player have winNumber
                    bool p1Match = markedPlayer1Cells.Find(cell => cell.CellValue == winNumberAsInt) != null;
                    bool p2Match = markedPlayer2Cells.Find(cell => cell.CellValue == winNumberAsInt) != null;
                    if (p1Match)
                    {
                        matchesPlayer1 += 1;
                    }
                    if (p2Match)
                    {
                        matchesPlayer2 += 1;
                    }
                }

                // when the count reaches 3 one of the winConditions is fulfilled
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

        private static void PrintBoard(List<Cell> cells)
        {
            int j = 0;
            Console.WriteLine("-------------");
            foreach (var cell in cells)
            {
                Console.Write(Cell.GenerateTictacSign(cell));

                if (j == 2 || j == 5 || j == 8)
                {
                    Console.WriteLine("\n-------------");
                }
                j++;
            }
        }

        private static void UserInput(List<Cell> cells)
        {
            Console.WriteLine("\nYour turn {0}", GameState.CurrentPlayer);
            Console.WriteLine("Enter key 1-9");

            // Outgoing value from ReadLine. This is used as the cell index
            int parsedInput = -1;

            while (true)
            {
                // check if the input is an int
                if (int.TryParse(Console.ReadLine(), out parsedInput))
                {
                    // check if the input is an index of List<Cell>
                    if (parsedInput >= 1 || parsedInput <= 9)
                    {
                        // check if cell is occupied
                        if (cells[parsedInput - 1].Owner == CellOwner.Undecided)
                        {
                            break;
                        }

                    }
                }
            }
            Console.WriteLine();

            // update cell array with user input
            if (GameState.CurrentPlayer == Player.Player1)
            {
                cells[parsedInput - 1].Owner = CellOwner.Player1;
                GameState.CurrentPlayer = Player.Player2;
            }
            else
            {
                cells[parsedInput - 1].Owner = CellOwner.Player2;
                GameState.CurrentPlayer = Player.Player1;
            }
        }

       
    }
}
