namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cell> cells = new List<Cell>();
            for (int i = 1; i <= 9; i++)
            {
                cells.Add(new Cell(i));
            }
            // remove
            foreach (var item in cells)
            {
                Console.WriteLine(item.CellValue);
            }

        }
    }
}
