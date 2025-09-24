namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board(); //Skapar ett nytt gameBoard objekt. Vill man ha möjlighet att spela flera gånger utan att programmet startar om måste vi antingen ta bort detta objekt (eller lägga in det i en lista) och skapa ett nytt för varje runda
            
            while (true)
            {
               
                gameBoard.PrintBoard(); //Skriv ut brädet

                string playerChoice = Console.ReadLine(); //Ta emot spelarens val i en sträng
                string currentMarker; //Deklarera en variabel för den nuvarande spelarens markör


                if (Player.isItPlayerOnesTurn)          //Om det är första spelarens tur, ändra currentMarker till "X"
                    currentMarker = Player.OneMarker;
                else                                    //Annars ändras currenMarker till "O"
                    currentMarker = Player.TwoMarker;

                if (gameBoard.ValidBoardChoice(playerChoice) && playerChoice.ToUpper() != "X" && playerChoice.ToUpper() != "O") //Utöver att kolla om spelarens val finns kvar på brädet ser vi även till att hantera om användaren har skrivit in "x" eller "o". ToUpper() är för att hantera båda fallen oavsett om stor eller liten bokstav har skrivits in
                {
                    gameBoard.PlayerMove(int.Parse(playerChoice), currentMarker); //Konverterar strängen från playerChoice till en int så den kan användas till ett index i spelbrädets Array. 
                }

                //Kalla på metod för att se ifall den nuvarande spelaren har vunnit

                Player.NextPlayersTurn(); //Byter till nästa spelares tur
            }
        }
    }
}
