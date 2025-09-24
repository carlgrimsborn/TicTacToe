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

            // run the game with the data
            GameState.RunGame(cells);
        }
    }
}
