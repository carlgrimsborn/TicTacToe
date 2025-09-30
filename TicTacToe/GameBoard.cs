using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameBoard
    {

        public string[] Board { get; set; } = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public  bool CheckVictory()
        {
            Console.Clear();
            bool row1 = Board[0] == Board[1] && Board[1] == Board[2];
            bool row2 = Board[3] == Board[4] && Board[4] == Board[5];
            bool row3 = Board[6] == Board[7] && Board[7] == Board[8];
            bool col1 = Board[0] == Board[3] && Board[3] == Board[6];
            bool col2 = Board[1] == Board[4] && Board[4] == Board[7];
            bool col3 = Board[2] == Board[5] && Board[5] == Board[8];
            bool diagDown = Board[0] == Board[4] && Board[4] == Board[8];
            bool diagUp = Board[6] == Board[4] && Board[4] == Board[2];
            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }

        public void PrintBoard ()
        {
            Console.Clear();

            int index = 0;
            for (int row = 1; row <= 3; row++)
            {
                Console.Write($"\n\t\n\t__");
                PrintSign(Board[index]);
                index++;

                Console.Write("__ __");
                PrintSign(Board[index]);
                Console.Write("__ __");
                index++;

                PrintSign(Board[index]);
               Console.Write("__");
                index++;
            }
        }

        public void PrintSign (string sign)
        {
            switch (sign)
            {
                case "X":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(sign);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    

                case "O":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(sign);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    Console.Write(sign);
                    break;
            }
        }
    }
}
