namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    /// <summary>
    /// Initialize a manufacturer.
    /// </summary>
    public abstract class Manufacturer
    {
        /// <summary>
        /// Generate a board.
        /// </summary>
        /// <returns>Returns the generated board.</returns>
        public abstract char[,] GenerateBoard();
    }
}
