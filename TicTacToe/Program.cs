namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cell> cells = new List<Cell>();

            // create the cells
            for (int i = 1; i <= 9; i++)
            {
                cells.Add(new Cell(i));
            }

            // example. remove later
            cells[0].Owner = CellOwner.Player2;
            cells[1].Owner = CellOwner.Player1;
            cells[2].Owner = CellOwner.Player2;
            cells[3].Owner = CellOwner.Player1;
            cells[4].Owner = CellOwner.Player1;
            cells[5].Owner = CellOwner.Player2;
            cells[6].Owner = CellOwner.Player1;
            cells[7].Owner = CellOwner.Player2;
            cells[8].Owner = CellOwner.Player1;

            // print board
            int j = 0;
            foreach (var cell in cells)
            {
                Console.Write(Cell.GenerateTictacSign(cell));

                if (j == 2 || j == 5 || j == 8)
                {
                    Console.WriteLine();
                }
                j++;
            }

            GameState.CalculateWinCondition(cells);
            Console.WriteLine("Winner: {0}", GameState.Winner);
        }

    }
}
