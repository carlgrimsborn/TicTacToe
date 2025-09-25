using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum PlayerName
    {
        Player1,
        Player2
    }

    public class Player
    {
        public int Score { get; set; }
        public PlayerName PlayerName { get; set; }

        public Player(PlayerName name)
        {
            this.PlayerName = name;
        }

        public void PrintPlayerScore()
        {
            Console.WriteLine($"{PlayerName} wins: {Score}");
        }

    }
}
