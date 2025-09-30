namespace TicTacToe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                GameBoard board = new GameBoard();

                do
                {
                    board.PrintBoard(State.NumTurns == 0);

                    if (State.Player1Turn)
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

                    Console.Write("\n\tVälj position (1-9): ");
                    string choice = Console.ReadLine();

                    if (board.SpelPlan.Contains(choice) && choice != "X" && choice != "O")
                    {
                        int spelplanIndex = Convert.ToInt32(choice) - 1;
                        if (State.Player1Turn)
                            board.SpelPlan[spelplanIndex] = "X";
                        else
                            board.SpelPlan[spelplanIndex] = "O";

                        State.Player1Turn = !State.Player1Turn;
                        State.NumTurns += 1; // Öka antalet drag
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ogiltigt val! Försök igen.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    board.CheckVictory();

                } while (State.GameRunning);

                if (State.GameRunning == false)
                {
                    // Visa slutresultat
                    board.PrintBoard(false);
                    if (!State.Player1Turn) // Den som nyss spelade
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
