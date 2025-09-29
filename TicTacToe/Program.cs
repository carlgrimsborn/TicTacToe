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
                    if (onlyShowOnce)
                        WelcomeMessage();
                    onlyShowOnce = false;
                    board.PrintBoard();
                    

                    if (player1Turn)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\tSpelare 1:s tur");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\tSpelare 2:s tur");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write("\tVälj position (1-9): ");
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
                        Console.Clear();
                        Console.WriteLine("Ogiltigt val! Försök igen.");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

                // Visa slutresultat
                board.PrintBoard();
                if (board.CheckVictory())
                {
                    if (!player1Turn) // Den som nyss spelade
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Spelare 1 vinner!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Spelare 2 vinner!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oavgjort!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.ReadKey();


            }
        }
        private static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\n\tVälkommen till TicTacToe!!!!");
            Console.ReadKey();
            Console.WriteLine("\n\t\n\tTvå spelare ska mata in tal 1-9 tills de får tre i rad.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
    
}
