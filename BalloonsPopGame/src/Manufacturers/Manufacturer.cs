namespace BalloonsPopGame.Srs.Manufacturers
{
    using BalloonsPopGame.Srs.Products;

    public abstract class Manufacturer
    {
        public abstract byte[,] GenerateBoard();
    }
}
