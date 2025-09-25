using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class GameState
    {
        public static bool IsRunning { get; set; } = true; //bool som avgör om programmet ska fortsätta

        public static int MoveCounter { get; set; } = 0;

        public static string[] WinConditions = { "123", "456", "789", "741", "852", "963", "159", "753" }; //String[] med alla möjliga vinster

        public static bool IsItPlayerOnesTurn { get; set; } = true; //Bool som avgör ifall det är första spelarens tur eller ej

        public static Player Player1 { get; set; } = new Player(PlayerName.Player1);
        public static Player Player2 { get; set; } = new Player(PlayerName.Player2);

        public static void UpdateToNextPlayer() //Metod som kallas efter en spelare har gjort sin tur, ändrar bool värdet till det motsatta
        {
            if (IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = false;
            else if (!IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = true;

        }

        public static void ResetGame()
        {
            Console.Clear();
            MoveCounter = 0;
            WinConditions = ["123", "456", "789", "741", "852", "963", "159", "753"];
            BoardController.BoardPieces = [ "1", "2", "3", "4", "5", "6", "7", "8", "9" ];
            IsItPlayerOnesTurn = true;

        }
        public static void TryAgain()
        {
            Console.WriteLine("\nTry Again? y/n");
            string? input = null;
            while (input != "y" && input != "n")
            {
                input = Console.ReadLine();
            }
            if (input == "y")
            {
                ResetGame();
            } else
            {
                IsRunning = false;
            }
        }
    }
}
