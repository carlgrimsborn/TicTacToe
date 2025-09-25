namespace TicTacToe
{
    internal class Program
    {
    
        static void Main(string[] args)
        {

            while (GameState.IsRunning)
            {
                BoardController.PrintBoard(GameState.IsItPlayerOnesTurn); //Skriv ut brädet

                string playerChoice = Console.ReadLine(); //Ta emot spelarens val i en sträng
                string currentMarker; //Deklarera en variabel för den nuvarande spelarens markör


                if (GameState.IsItPlayerOnesTurn)          //Om det är första spelarens tur, ändra currentMarker till "X"
                    currentMarker = "X";
                else                                    //Annars ändras currenMarker till "O"
                    currentMarker = "O";

                if (BoardController.ValidBoardChoice(playerChoice) && playerChoice.ToUpper() != "X" && playerChoice.ToUpper() != "O") //Utöver att kolla om spelarens val finns kvar på brädet ser vi även till att hantera om användaren har skrivit in "x" eller "o". ToUpper() är för att hantera båda fallen oavsett om stor eller liten bokstav har skrivits in
                {
                    BoardController.UpdateBoard(int.Parse(playerChoice), currentMarker); //Konverterar strängen från playerChoice till en int så den kan användas till ett index i spelbrädets Array. 
                    GameState.MoveCounter += 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Make a valid move on the board"); //Exempel error text ifall spelaren gör ett ogiltigt val
                    continue; //Går tillbaka till början av loopen, så att samma spelare kan fortsätta göra ett val tills ett giltigt val har gjort
                }

                Console.Clear();
                CheckWinner.PlaceMarkerInWinConditions(playerChoice, currentMarker); //Placerar spelarens markör i string[] med WinConditions
                CheckWinner.CheckPlayerWin(); //Ser igenom string[] WinConditions om den innehåller "xxx" eller "ooo"

            }
        }
    }
}
