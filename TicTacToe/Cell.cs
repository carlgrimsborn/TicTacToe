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
            switch(cell.Owner)
            {
                case CellOwner.Player1:
                    return "X";
                case CellOwner.Player2:
                    return "O";
                default:
                    return cell.CellValue.ToString();
            }
        }
    }
}
