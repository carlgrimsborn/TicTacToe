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
                if (CheckWinner.DidPlayerWin(gameBoard.Board))
                    PrintText.AnnounceWinner();
                else
                    PrintText.announceTie();
                Console.ReadKey();


            }
        }


    }
    
}
