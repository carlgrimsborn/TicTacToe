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

        public  void CheckVictory()
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
            bool winConditionFulfilled = row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
            if (winConditionFulfilled && State.NumTurns != 9)
            {
                State.GameRunning = false;
            }
        }

        public void PrintBoard (bool isFirstTurn)
        {
            
            if (isFirstTurn)
                WelcomeMessage();

            Console.Clear();
            Console.Write("\n\t\n\t"); Console.Write($"__{PrintSign(SpelPlan[0])}__"); Console.Write($" __{PrintSign(SpelPlan[1])}__ "); Console.Write($"__{PrintSign(SpelPlan[2])}__"); //självaste board i en metod
            Console.Write("\n\t\n\t"); Console.Write($"__{PrintSign(SpelPlan[3])}__"); Console.Write($" __{PrintSign(SpelPlan[4])}__ "); Console.Write($"__{PrintSign(SpelPlan[5])}__");
            Console.Write("\n\t\n\t"); Console.Write($"__{PrintSign(SpelPlan[6])}__"); Console.Write($" __{PrintSign(SpelPlan[7])}__ "); Console.Write($"__{PrintSign(SpelPlan[8])}__\n\t\n\t");
            
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        public string PrintSign (string sign)
        {
            switch (sign)
            {
                case "X":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "O":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            return sign;
        }

        public void WelcomeMessage ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\n\tVälkommen till TicTacToe!!!!");
            Console.ReadKey();
            Console.WriteLine("\n\t\n\tTvå spelare ska ska mata in tal 1-9 tills de får tre i rad.");
            Console.ReadKey();
        }

    }
}
