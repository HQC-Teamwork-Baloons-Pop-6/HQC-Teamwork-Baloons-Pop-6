namespace BalloonsPopGame.Srs.Manufacturers
{
    using BalloonsPopGame.Srs.Products;

    public class TelerikSoft : Manufacturer
    {
        public override byte[,] GenerateBoard()
        {
            var board = new Board10x10();
            return board.GenerateBoard();
        }
    }
}
