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
