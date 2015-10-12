namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    /// <summary>
    /// Creates new custom board.
    /// </summary>
    public class TelerikSoft : Manufacturer
    {
        /// <summary>
        /// Initialize new board with size 10 to 10.
        /// </summary>
        /// <returns>Returns created board.</returns>
        public override char[,] GenerateBoard()
        {
            var board = new Board10X10();
            return board.GenerateBoard();
        }
    }
}
