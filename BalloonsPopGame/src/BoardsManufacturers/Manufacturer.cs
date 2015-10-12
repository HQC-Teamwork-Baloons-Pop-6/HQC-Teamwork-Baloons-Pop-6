namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    /// <summary>
    /// Initialize a manufacturer
    /// </summary>
    public abstract class Manufacturer
    {
        public abstract char[,] GenerateBoard();
    }
}
