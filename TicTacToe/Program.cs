namespace TicTacToe
{
    internal class Program
    {


        static void Main(string[] args) //Carl
        {
            {
                GameBoard gameBoard = new GameBoard(); //Thomas

                while (GameState.ShouldGameKeepRunning(gameBoard.Board)) //Margret (checkwinner)
                {
                    if (!GameState.HasPrintedWelcomeMessage)
                        PrintText.WelcomeMessage();
                    
                    gameBoard.PrintBoard(); //Emilia
                    PrintText.TurnIndicator();
                    PrintText.ChoosePosition();
                    GameActions.HandleUserInput(gameBoard);
                }

                // Visa slutresultat
                gameBoard.PrintBoard(); //Thomas
                if (GameActions.CheckVictory(gameBoard.Board))
                {
                    gameBoard.PrintBoard();
                    PrintText.AnnounceWinner();
                }
                
                else
                {
                    gameBoard.PrintBoard();
                    PrintText.AnnounceTie();
                }
                    
                Console.ReadKey();
            }
        }


    }
    
}
