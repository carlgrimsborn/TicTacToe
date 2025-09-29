using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameBoard
    {

        public string[] SpelPlan { get; set; } = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public  bool CheckVictory()
        {
            Console.Clear();
            bool row1 = SpelPlan[0] == SpelPlan[1] && SpelPlan[1] == SpelPlan[2];
            bool row2 = SpelPlan[3] == SpelPlan[4] && SpelPlan[4] == SpelPlan[5];
            bool row3 = SpelPlan[6] == SpelPlan[7] && SpelPlan[7] == SpelPlan[8];
            bool col1 = SpelPlan[0] == SpelPlan[3] && SpelPlan[3] == SpelPlan[6];
            bool col2 = SpelPlan[1] == SpelPlan[4] && SpelPlan[4] == SpelPlan[7];
            bool col3 = SpelPlan[2] == SpelPlan[5] && SpelPlan[5] == SpelPlan[8];
            bool diagDown = SpelPlan[0] == SpelPlan[4] && SpelPlan[4] == SpelPlan[8];
            bool diagUp = SpelPlan[6] == SpelPlan[4] && SpelPlan[4] == SpelPlan[2];
            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }



        public void PrintBoard ()
        {
            Console.Clear();

            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\n\t\n\t__");
                PrintSign(SpelPlan[j]);
                j++;

                Console.Write("__ __");
                PrintSign(SpelPlan[j]);
                Console.Write("__ __");
                j++;

                PrintSign(SpelPlan[j]);
               Console.Write("__");
                j++;
            }
            
            /*
            Console.WriteLine($"\n\t\n\t__{PrintSign(SpelPlan[0])}__ __{PrintSign(SpelPlan[1])}__ __{PrintSign(SpelPlan[2])}__"); //självaste board i en metod
            Console.WriteLine($"\n\t\n\t__{PrintSign(SpelPlan[3])}__ __{PrintSign(SpelPlan[4])}__ __{PrintSign(SpelPlan[5])}__");
            Console.WriteLine($"\n\t\n\t__{PrintSign(SpelPlan[6])}__ __{PrintSign(SpelPlan[7])}__ __{PrintSign(SpelPlan[8])}__");
            Console.ForegroundColor = ConsoleColor.Gray;
            */
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
