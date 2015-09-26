namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using BalloonsPopGame.Srs.Boards;

    public abstract class Manufacturer
    {
        public abstract char[,] GenerateBoard();
    }
}
