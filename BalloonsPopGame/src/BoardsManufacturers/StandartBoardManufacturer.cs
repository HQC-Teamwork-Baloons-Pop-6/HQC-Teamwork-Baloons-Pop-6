namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    /// <summary>
    /// Creates a standard board.
    /// </summary>
    public class StandartBoardManufacturer : Manufacturer
    {
        /// <summary>
        /// Generates new board.
        /// </summary>
        /// <returns>Returns the generated board.</returns>
        public override char[,] GenerateBoard()
        {
            var board = new Board5X10();
            return board.GenerateBoard();
        }
    }
}
