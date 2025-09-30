using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class PrintText
    {

        public static void invalidInput ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Ogiltigt val! Försök igen.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void TurnIndicator ()
        {
            if (GameState.Player1Turn)
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
                
        }

        public static void ChoosePosition ()
        {
            Console.Write("\tVälj position (1-9): ");
        }

        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t\n\tVälkommen till TicTacToe!!!!");
            Console.ReadKey();
            Console.WriteLine("\n\t\n\tTvå spelare ska mata in tal 1-9 tills de får tre i rad.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
            GameState.HasPrintedWelcomeMessage = true;
        }

        public static void AnnounceWinner ()
        {
            if (!GameState.Player1Turn)
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
        public static void announceTie ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oavgjort!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
