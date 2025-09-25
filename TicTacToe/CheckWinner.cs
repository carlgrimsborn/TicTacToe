using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class CheckWinner
    {
        static string[] WinConditions = { "123", "456", "789", "741", "852", "963", "159", "753" }; //String[] med alla möjliga vinster

        public static void PlaceMarkerInWinConditions(string playerChoice, string currentMarker) //Metod som byter ut den motsvarande siffran på spelbrädet som en av spelarna har valt till dens spelares markör
        {

            char whereToPutMarker = Convert.ToChar(playerChoice);
            char marker = Convert.ToChar(currentMarker);

            for (int i = 0; i < WinConditions.Length; i++) //Loopar igenom alla strängar i winConditions
            {
                for (int j = 0; j < WinConditions[i].Length; j++) //Loopar igenom alla individuella chars i varje sträng i winConditions
                {
                    // put marker in WinConditions array
                    if (WinConditions[i][j] == whereToPutMarker)
                    {
                        char[] winCondition = WinConditions[i].ToCharArray();
                        winCondition[j] = marker;
                        string replacement = new string(winCondition);
                        WinConditions[i] = replacement;
                    }
                }
            }
        }

        public static void DidPlayerWin(int moveCounter)
        {

            if (moveCounter >= 5) //Börja inte kolla efter en vinst innan 5 drag har genomförts
            {
                bool winnerIsDecided = false;

                foreach (string winCondition in WinConditions)
                {
                    DeclareWinner(winCondition, out winnerIsDecided);
                    if(winnerIsDecided)
                    {
                        break;
                    }
                }
            }

            void DeclareWinner(string winCondition, out bool winnerIsDecided)
            {
                string? playerWhoWon = winCondition == "XXX" ? "Player1" : winCondition == "OOO" ? "Player2" : null;
                if (playerWhoWon != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{playerWhoWon} won!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                    //Avsluta spelet
                    GameState.IsRunning = false;
                    winnerIsDecided = true;
                    return;
                }
                winnerIsDecided = false;
            }

            //lägg till logik så att vi inte kommer hit ifall en vinnare har funnits
            if (moveCounter == 9)
            {
                Console.WriteLine("Game ends in a tie");
            }
            else
            {
                //Forsätt med spelet (endast här ifall vi ändrar från "void" till att istället returnera ett variabelvärde)
            }
        }

        public static void PlayerWon()
        {

        }

    }
}
