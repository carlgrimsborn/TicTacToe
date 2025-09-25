using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class BoardController //Class med metod för att skriva ut spelbrädet, metod för att ändra en brädposition till en spelares markör och en metod för att se om en spelares val är giltigt
    {
        public static string[] BoardPieces { get; set; } = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };        

        public static void PrintBoard(bool isItPlayerOnesTurn) //Metod som kallas när spelplanen ska skrivas ut. För nuvarande saknas: Spelinstruktioner, indikator om vems tur det är, färger och förhoppningsvis ett allmänt snyggare UI
        {

            if (isItPlayerOnesTurn)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player1 make a move!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
                
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player2 make a move!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            PrintTicTacField();
            Console.Write("\n  Choice:");
        }
        public static void PrintTicTacField()
        {
            Console.WriteLine($"\n {BoardPieces[0]} | {BoardPieces[1]} | {BoardPieces[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {BoardPieces[3]} | {BoardPieces[4]} | {BoardPieces[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {BoardPieces[6]} | {BoardPieces[7]} | {BoardPieces[8]}");
        }
        public static void TurnIndicator ()
        {
            
            
        }

        public static void UpdateBoardPieces(int playerChoice, string playerMarker) //Tar in en spelares val på spelbrädet, som när metoden kallas konverteras från string till int och byter ut spelarens val på brädet med spelarens markör
        {

            BoardPieces[playerChoice - 1] = playerMarker; //-1 då index börjar från 0 och inte 1
        }

        public static bool ValidBoardChoice (string playerChoice) //Kollar ifall det val som spelaren har gjort finns med på spelbrädet. Detta säkrar både att spelaren har skrivit in ett val i rätt format men även att den inte får välja en position på brädet som redan är upptagen
        {
            if (BoardPieces.Contains(playerChoice)) 
                return true;
            else
                return false;
        }
    }
}
