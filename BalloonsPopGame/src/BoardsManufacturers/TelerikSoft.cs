namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using BalloonsPopGame.Srs.Boards;

    public class TelerikSoft : Manufacturer
    {
        public override char[,] GenerateBoard()
        {
            var board = new Board10x10();
            return board.GenerateBoard();
        }
    }
}
