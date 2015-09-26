namespace BalloonsPopGame.Srs.Command
{
    using BalloonsPopGame.Srs.Boards;

    public class RestartCommand : IInputCommand
    {
        private Board board;
        private IPrinterManager printer;

        public RestartCommand(Board board, IPrinterManager printer)
        {
            this.board = board;
            this.printer = printer;
        }

        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            playBoard = this.board.GenerateBoard();
            this.printer.PrintPlayBoard(playBoard);
            userMoves = 0;
        }
    }
}
