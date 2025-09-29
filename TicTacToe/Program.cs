namespace TicTacToe
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            {
                GameBoard board = new GameBoard();
                bool player1Turn = true;
                int numTurns = 0;
                bool onlyShowOnce = true;
                
                while (!board.CheckVictory() && numTurns != 9)
                {
                    board.PrintBoard(onlyShowOnce);
                    onlyShowOnce = false;
                    
                    if (player1Turn)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Spelare 1:s tur");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Spelare 2:s tur");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write("Välj position (1-9): ");
                    string choice = Console.ReadLine();

                    if (board.SpelPlan.Contains(choice) && choice != "X" && choice != "O")
                    {
                        int spelplanIndex = Convert.ToInt32(choice) - 1;
                        if (player1Turn)
                            board.SpelPlan[spelplanIndex] = "X";
                        else
                            board.SpelPlan[spelplanIndex] = "O";

                        player1Turn = !player1Turn;
                        numTurns++; // Öka antalet drag
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogiltigt val! Försök igen.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

                // Visa slutresultat
                board.Printspelplan();
                if (board.CheckVictory())
                {
                    if (!player1Turn) // Den som nyss spelade

                        Console.WriteLine("Spelare 1 vinner!");
                    else
                        Console.WriteLine("Spelare 2 vinner!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oavgjort!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

        }
    }
}
