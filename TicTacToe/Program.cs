namespace TicTacToe
{
    internal class Program
    {
        public static bool IsRunning { get; set; } = true; //bool som avgör om programmet ska fortsätta
        
        static void Main(string[] args)
        {
            Board gameBoard = new Board(); //Skapar ett nytt gameBoard objekt. Vill man ha möjlighet att spela flera gånger utan att programmet startar om måste vi antingen ta bort detta objekt (eller lägga in det i en lista) och skapa ett nytt för varje runda
            CheckWinner checkWinner = new CheckWinner();
            int moveCounter = 0;
            while (IsRunning)
            {
                gameBoard.PrintBoard(); //Skriv ut brädet

                string playerChoice = Console.ReadLine(); //Ta emot spelarens val i en sträng
                string currentMarker; //Deklarera en variabel för den nuvarande spelarens markör


                if (Player.IsItPlayerOnesTurn)          //Om det är första spelarens tur, ändra currentMarker till "X"
                    currentMarker = Player.OneMarker;
                else                                    //Annars ändras currenMarker till "O"
                    currentMarker = Player.TwoMarker;

                if (gameBoard.ValidBoardChoice(playerChoice) && playerChoice.ToUpper() != "X" && playerChoice.ToUpper() != "O") //Utöver att kolla om spelarens val finns kvar på brädet ser vi även till att hantera om användaren har skrivit in "x" eller "o". ToUpper() är för att hantera båda fallen oavsett om stor eller liten bokstav har skrivits in
                {
                    gameBoard.PlayerMove(int.Parse(playerChoice), currentMarker); //Konverterar strängen från playerChoice till en int så den kan användas till ett index i spelbrädets Array. 
                    moveCounter++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Make a valid move on the board"); //Exempel error text ifall spelaren gör ett ogiltigt val
                    continue; //Går tillbaka till början av loopen, så att samma spelare kan fortsätta göra ett val tills ett giltigt val har gjort
                }
                
                checkWinner.PlaceMarkerInWinConditions(playerChoice, currentMarker); //Placerar spelarens markör i string[] med WinConditions
                checkWinner.DidPlayerWin(moveCounter); //Ser igenom string[] WinConditions om den innehåller "xxx" eller "ooo"

                Player.NextPlayersTurn(); //Byter till nästa spelares tur
                Console.Clear();
            }
        }
    }
}
