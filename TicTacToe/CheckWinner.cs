using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class CheckWinner
    {
        
        private string[] WinConditions { get; set; } = { "123", "456", "789", "741", "852", "963", "159", "753" }; //String[] med alla möjliga vinster
        
        public void PlaceMarkerInWinConditions (string playerChoice, string currentMarker) //Metod som byter ut den motsvarande siffran på spelbrädet som en av spelarna har valt till dens spelares markör
        {

            char whereToPutMarker = Convert.ToChar(playerChoice);
            char marker = Convert.ToChar(currentMarker);
            
            for (int i = 0; i < WinConditions.Length; i++) //Loopar igenom alla strängar i winConditions
            {
                for (int j = 0; j < WinConditions[i].Length; j++) //Loopar igenom alla individuella chars i varje sträng i winConditions
                {
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
        
        public void DidPlayerWin (int moveCounter)
        {
            
            if (moveCounter >= 5) //Börja inte kolla efter en vinst innan 5 drag har genomförts
            {
                foreach (string winCondition in WinConditions)
                {
                    if (winCondition == "XXX")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player1 won!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Program.IsRunning = false;
                        break;
                        //Avsluta spelet
                    }
                    else if (winCondition == "OOO")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Player2 won!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Program.IsRunning = false;
                        break;
                        //Avsluta spelet
                    }
                }
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
        
        
        
        public void PlayerWon ()
        {

        }



        
    }
}
