using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class CheckWinner
    {
        //Logik för att se ifall en spelare har vunnit eller ej
        

        //Idéer på logik:
        //Ha ett int värde som antingen har koll på hur många rundor som körts eller om någon spelare har 3 markörer på brädet. Börja inte se om någon har vunnit ifall ingen spelare inte har 3 markörer placerade.
        //Istället för att skapa fall för varje möjlig vinst på brädet, alltså alla möjliga tre i rad ( 1 + 5 + 9, 1 + 2 + 3, 3 + 6 + 9 etc), så kan man se dem möjliga vinsterna utifrån spelarnas redan markörer eller de platser på spelbrädet som inte har blivit markerade ännu.
    }
}
