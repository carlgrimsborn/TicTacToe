using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class CheckWinner
    {

        public static void PlaceMarkerInWinConditions(string playerChoice, string currentMarker) //Metod som byter ut den motsvarande siffran på spelbrädet som en av spelarna har valt till dens spelares markör
        {

            char whereToPutMarker = Convert.ToChar(playerChoice);
            char marker = Convert.ToChar(currentMarker);

            for (int i = 0; i < GameState.WinConditions.Length; i++) //Loopar igenom alla strängar i winConditions
            {
                for (int j = 0; j < GameState.WinConditions[i].Length; j++) //Loopar igenom alla individuella chars i varje sträng i winConditions
                {
                    // put marker in WinConditions array
                    if (GameState.WinConditions[i][j] == whereToPutMarker)
                    {
                        char[] winCondition = GameState.WinConditions[i].ToCharArray();
                        winCondition[j] = marker;
                        string replacement = new string(winCondition);
                        GameState.WinConditions[i] = replacement;
                    }
                }
            }
        }

        public static void CheckPlayerWin()
        {
            PlayerName? decidedWinner = null;

            if (GameState.MoveCounter >= 5) //Börja inte kolla efter en vinst innan 5 drag har genomförts
            {
                foreach (string winCondition in GameState.WinConditions)
                {
                    PlayerName? playerWhoWon = winCondition == "XXX" ? PlayerName.Player1 : winCondition == "OOO" ? PlayerName.Player2 : null;
                    if (playerWhoWon != null)
                    {
                        decidedWinner = playerWhoWon;
                        break;
                    }
                }
            }

            if (decidedWinner != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{decidedWinner} won!");
                Console.ForegroundColor = ConsoleColor.Gray;
                BoardController.PrintTicTacField();

                // set player score
                if (decidedWinner == PlayerName.Player1)
                {
                    GameState.Player1.Score += 1;
                }
                else
                {
                    GameState.Player2.Score += 1;
                }

                // print player scores
                Console.WriteLine();
                GameState.Player1.PrintPlayerScore();
                GameState.Player2.PrintPlayerScore();
                
                // Kolla om en användaren vill spela igen
                GameState.TryAgain();
            }
            else if (GameState.MoveCounter == 9)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Game ends in a tie");
                Console.ForegroundColor = ConsoleColor.Gray;
                BoardController.PrintTicTacField();
                GameState.TryAgain();
            }
            else
            {
                // continue game
                GameState.UpdateToNextPlayer(); //Byter till nästa spelares tur
            }
        }

        public static void PlayerWon()
        {

        }

    }
}
