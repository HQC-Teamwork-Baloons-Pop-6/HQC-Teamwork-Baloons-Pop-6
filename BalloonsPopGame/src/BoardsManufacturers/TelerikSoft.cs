namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    public class TelerikSoft : Manufacturer
    {
        public override char[,] GenerateBoard()
        {
            var board = new Board10X10();
            return board.GenerateBoard();
        }
    }
}
