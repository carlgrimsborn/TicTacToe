using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public enum CellOwner
    {
        Player1,
        Player2,
        Undecided
    }

    public class Cell
    {
        public Cell(int index)
        {
            this.CellValue = index;
        }
        public CellOwner Owner { get; set; } = CellOwner.Undecided;
        public int CellValue { get; private set; }

        public static string GenerateTictacSign(Cell cell)
        {
            bool cellIsInMiddle = cell.CellValue == 2 || cell.CellValue == 5 || cell.CellValue == 8;
            bool cellIsToTheRight = cell.CellValue == 3 || cell.CellValue == 6 || cell.CellValue == 9;

            if (cell.Owner == CellOwner.Player1)
            {
                if (cellIsInMiddle)
                {
                    return "| X |";
                } else if(cellIsToTheRight)
                {
                    return " X |";
                }
                    return "| X ";
            }

            if (cell.Owner == CellOwner.Player2)
            {
                if (cellIsInMiddle)
                {
                    return "| O |";
                }
                else if (cellIsToTheRight)
                {
                    return " O |";
                }
                return "| O ";
            }

            if (cellIsInMiddle)
            {
                return $"| {cell.CellValue} |";
            }
            else if (cellIsToTheRight)
            {
                return $" {cell.CellValue} |";
            }
            return $"| {cell.CellValue} ";

        }
    }
}
