namespace BalloonsPopGame.Srs.Manufacturers
{
    using BalloonsPopGame.Srs.Boards;

    public abstract class Manufacturer
    {
        public abstract char[,] GenerateBoard();
    }
}
