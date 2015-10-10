namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    public class StandartBoardManufacturer : Manufacturer
    {
        public override char[,] GenerateBoard()
        {
            var board = new Board5X10();
            return board.GenerateBoard();
        }
    }
}
