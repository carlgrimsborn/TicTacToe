using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class Player //Statisk Class som innehåller de två markörerna för spelarna och en bool som avgör vems tur det är
    {
        public static string OneMarker { get; } = "X"; //
        public static string TwoMarker { get; } = "O";

        



        //Kan bryta ut denna nedre del till en egen klass (kanske "PlayerTurn" eller något), alternativt att ta bort hela övre delen och endast arbeta med spelarnas markörer lokalt
        public static bool IsItPlayerOnesTurn { get; set; } = true; //Bool som avgör ifall det är första spelarens tur eller ej

        public static void NextPlayersTurn () //Metod som kallas efter en spelare har gjort sin tur, ändrar bool värdet till det motsatta
        {
            if (IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = false;
            else if (!IsItPlayerOnesTurn)
                IsItPlayerOnesTurn = true;

        }


    }
}
