namespace BalloonsPopGame.Srs.Printers
{
    /// <summary>
    /// Interface for the printer manager.
    /// </summary>
    public interface IPrinterManager
    {
        /// <summary>
        /// Prints a play board.
        /// </summary>
        /// <param name="playBoard">Play board for printing.</param>
        void PrintPlayBoard(char[,] playBoard);
    }
}
