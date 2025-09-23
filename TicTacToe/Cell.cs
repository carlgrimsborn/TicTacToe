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
        Circle
    }

    internal class Cell(int index)
    {
        public VariantType Variant { get; set; } = VariantType.Circle;
        public int CellValue { get; set; } = index;


    }
}
