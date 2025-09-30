using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class GameActions
    {
        public static void HandleUserInput (GameBoard gameBoard)
        {
            string choice = Console.ReadLine();

            if (gameBoard.Board.Contains(choice) && choice != "X" && choice != "O")
            {
                int boardIndex = Convert.ToInt32(choice) - 1;
                if (GameState.Player1Turn)
                    gameBoard.Board[boardIndex] = "X";
                else
                    gameBoard.Board[boardIndex] = "O";

                ChangeTurn();
                GameState.NumTurns++; // Öka antalet drag
            }
            else
            {
                PrintText.invalidInput();
            }
        }

        public static void PlaceMarker(GameBoard gameBoard, string choice)
        {
            int boardIndex = Convert.ToInt32(choice) - 1;
            if (!GameState.Player1Turn)
                gameBoard.Board[boardIndex] = "X";
            else
                gameBoard.Board[boardIndex] = "O";
        }

        public static void ChangeTurn()
        {
            GameState.Player1Turn = !GameState.Player1Turn;
        }
    }
}
