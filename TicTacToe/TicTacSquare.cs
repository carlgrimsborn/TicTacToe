using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    enum VariantType
    {
        Cross,
        Cirle
    }

    internal class TicTacSquare
    {
        public int Variant { get; set; }
    }
}
