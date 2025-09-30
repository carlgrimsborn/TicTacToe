namespace TicTacToe
{
    internal class Program
    {


        static void Main(string[] args)
        {
            {
                GameBoard gameBoard = new GameBoard();

                while (GameState.ShouldGameKeepRunning(gameBoard.Board))
                {
                    if (!GameState.HasPrintedWelcomeMessage)
                        PrintText.WelcomeMessage();
                    
                    gameBoard.PrintBoard();
                    PrintText.TurnIndicator();
                    PrintText.ChoosePosition();
                    GameActions.HandleUserInput(gameBoard);
                }

                // Visa slutresultat
                gameBoard.PrintBoard();
                if (GameActions.DidPlayerWin(gameBoard.Board))
                {
                    gameBoard.PrintBoard();
                    PrintText.AnnounceWinner();
                }
                
                else
                {
                    gameBoard.PrintBoard();
                    PrintText.announceTie();
                }
                    
                Console.ReadKey();
            }
        }


    }
    
}
