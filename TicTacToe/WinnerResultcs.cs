using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class WinnerResultcs
    {

        /// public int drag;
        // public int räknedrag;
        //public int Winner;
        private string[] WinConditions { get; set; } = { "123", "456", "789", "741", "852", "963", "159", "753" }; //String[] med alla möjliga vinster (Från Thomas och Carl)

        public void DidPlayerWin(int allaDrag, string[] Board)
        {

            if (allaDrag >= 5) //Börja inte kolla efter en vinst innan 5 drag har genomförts
            {
                foreach (string winCondition in WinConditions)
                {
                    if (Board[int.Parse(winCondition[0].ToString()) - 1] == "X" &&
                        Board[int.Parse(winCondition[1].ToString()) - 1] == "X" &&
                       Board[int.Parse(winCondition[2].ToString()) - 1] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\t\n\tSpelare1 har vunnit!!");
                        Console.ForegroundColor = ConsoleColor.Gray;


                        Environment.Exit(0);

                        //Avsluta spelet



                    }
                    else if (Board[int.Parse(winCondition[0].ToString()) - 1] == "O" &&
                        Board[int.Parse(winCondition[1].ToString()) - 1] == "O" &&
                       Board[int.Parse(winCondition[2].ToString()) - 1] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Spelare2 har vunnit!!");
                        Console.ForegroundColor = ConsoleColor.Gray;




                        Environment.Exit(0);



                    }


                }
            }
        }
    }
}

