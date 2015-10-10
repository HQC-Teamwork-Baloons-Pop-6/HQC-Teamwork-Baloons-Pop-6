namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    /// <summary>
    /// Inicialize a manufacturer
    /// </summary>
    public abstract class Manufacturer
    {
        public abstract char[,] GenerateBoard();
    }
}
