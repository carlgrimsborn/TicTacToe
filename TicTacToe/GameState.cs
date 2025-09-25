using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class GameState
    {
        public static bool IsRunning { get; set; } = true; //bool som avgör om programmet ska fortsätta

        public static bool IsItPlayerOnesTurn { get; set; } = true; //Bool som avgör ifall det är första spelarens tur eller ej

        public static void NextPlayersTurn() //Metod som kallas efter en spelare har gjort sin tur, ändrar bool värdet till det motsatta
        {
            if (IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = false;
            else if (!IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = true;

        }
    }
}
