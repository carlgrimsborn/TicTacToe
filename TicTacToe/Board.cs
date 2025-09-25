using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board //Class med metod för att skriva ut spelbrädet, metod för att ändra en brädposition till en spelares markör och en metod för att se om en spelares val är giltigt
    {
        public string[] _BoardPieces { get; set; }
        public Board(string[] boardPieces)
        {
            _BoardPieces = boardPieces;
        }

        public void PrintBoard(bool isItPlayerOnesTurn) //Metod som kallas när spelplanen ska skrivas ut. För nuvarande saknas: Spelinstruktioner, indikator om vems tur det är, färger och förhoppningsvis ett allmänt snyggare UI
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
                
            Console.WriteLine($"\n {_BoardPieces[0]} | {_BoardPieces[1]} | {_BoardPieces[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {_BoardPieces[3]} | {_BoardPieces[4]} | {_BoardPieces[5]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {_BoardPieces[6]} | {_BoardPieces[7]} | {_BoardPieces[8]}");
            Console.Write("\n  Choice:");
        }
        public void TurnIndicator ()
        {
            
            
        }

        public void PlayerMove(int playerChoice, string playerMarker) //Tar in en spelares val på spelbrädet, som när metoden kallas konverteras från string till int och byter ut spelarens val på brädet med spelarens markör
        {

            _BoardPieces[playerChoice - 1] = playerMarker; //-1 då index börjar från 0 och inte 1
        }

        public bool ValidBoardChoice (string playerChoice) //Kollar ifall det val som spelaren har gjort finns med på spelbrädet. Detta säkrar både att spelaren har skrivit in ett val i rätt format men även att den inte får välja en position på brädet som redan är upptagen
        {
            if (_BoardPieces.Contains(playerChoice)) 
                return true;
            else
                return false;
        }
    }
}
