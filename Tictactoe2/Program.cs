namespace Tictactoe2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] spelplan = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool player1Turn = true;
            int numTurns = 0;

            while (!CheckVictory(spelplan) && numTurns != 9)
            {
                Printspelplan(spelplan);

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

                if (spelplan.Contains(choice) && choice != "X" && choice != "O")
                {
                    int spelplanIndex = Convert.ToInt32(choice) - 1;
                    if (player1Turn)
                        spelplan[spelplanIndex] = "X";
                    else
                        spelplan[spelplanIndex] = "O";

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
            Printspelplan(spelplan);
            if (CheckVictory(spelplan))
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

        static void Printspelplan(string[] spelplan)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(spelplan[i * 3 + j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
        }

        static bool CheckVictory(string[] spelplan)
        {
            Console.Clear();
            bool row1 = spelplan[0] == spelplan[1] && spelplan[1] == spelplan[2];
            bool row2 = spelplan[3] == spelplan[4] && spelplan[4] == spelplan[5];
            bool row3 = spelplan[6] == spelplan[7] && spelplan[7] == spelplan[8];
            bool col1 = spelplan[0] == spelplan[3] && spelplan[3] == spelplan[6];
            bool col2 = spelplan[1] == spelplan[4] && spelplan[4] == spelplan[7];
            bool col3 = spelplan[2] == spelplan[5] && spelplan[5] == spelplan[8];
            bool diagDown = spelplan[0] == spelplan[4] && spelplan[4] == spelplan[8];
            bool diagUp = spelplan[6] == spelplan[4] && spelplan[4] == spelplan[2];
            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }
    }
}

