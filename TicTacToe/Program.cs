namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\n\tVälkommen till TicTacToe!!!!");
            Console.ReadKey();
            Console.WriteLine("\n\t\n\tTvå spelare ska ska mata in tal 1-9 tills de får tre i rad.");
            Console.ReadKey();
            Console.WriteLine($"\n\t\n\t__1__ __2__ __3__"); //självaste board
            Console.WriteLine($"\n\t\n\t__4__ __5__ __6__");
            Console.WriteLine($"\n\t\n\t__7__ __8__ __9__");

            string[] Board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //array för board
            WinnerResultcs result = new WinnerResultcs();
            int allaDrag = 0;
            while (true)
            {

                Console.WriteLine("\n\t\n\tSpelare1 (X) Välj mellan 1-9");//fråga spelare1
                string input = Console.ReadLine();
                int indexplayer1 = int.Parse(input) - 1;
                string player1 = "X";


                if (Board[indexplayer1] != "X" && Board[indexplayer1] != "O")
                {
                    Board[indexplayer1] = player1;

                    allaDrag++;

                }
                result.DidPlayerWin(allaDrag, Board);
                WholeBoard(Board); //Board skall visas efter spelar1 tur

                Console.WriteLine("\n\t\n\tSpelare2 (O) Välj mellan 1-9"); //fråga spelare2
                string input2 = Console.ReadLine();
                int indexplayer2 = int.Parse(input2) - 1;
                string player2 = "O";


                if (Board[indexplayer2] != "O" && Board[indexplayer2] != "X")
                {

                    Board[indexplayer2] = player2;
                    allaDrag++;
                    //Board skall visas efter spelar2 tur

                }

                WholeBoard(Board);
                result.DidPlayerWin(allaDrag, Board);

            }

        }

        static void WholeBoard(string[] Board)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine($"\n\t\n\t__{Board[0]}__ __{Board[1]}__ __{Board[2]}__"); //självaste board i en metod
            Console.WriteLine($"\n\t\n\t__{Board[3]}__ __{Board[4]}__ __{Board[5]}__");
            Console.WriteLine($"\n\t\n\t__{Board[6]}__ __{Board[7]}__ __{Board[8]}__");


        }



    }



}
    
