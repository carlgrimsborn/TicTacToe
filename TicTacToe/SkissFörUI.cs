using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class SkissFörUI
    {
        public static void TestMethod()
        {
            string[] spelplan = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("__________________");
            Console.WriteLine($"| {spelplan[0]} | {spelplan[1]} | {spelplan[2]}");
            Console.ReadKey();
            spelplan[0] = "X";
            Console.WriteLine("__________________");
            Console.WriteLine($"| {spelplan[0]} | {spelplan[1]} | {spelplan[2]}");
            Console.ReadKey();
        }
    }

       
}
