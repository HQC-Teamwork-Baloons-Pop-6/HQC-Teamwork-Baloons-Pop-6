namespace BalloonsPopGame.Srs.Manufacturers
{
    using BalloonsPopGame.Srs.Boards;

    public class StandartBoardManufacturer : Manufacturer
    {
        public override char[,] GenerateBoard()
        {
            var board = new Board5x10();
            return board.GenerateBoard();
        }
    }
}
