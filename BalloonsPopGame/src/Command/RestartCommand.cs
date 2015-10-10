namespace BalloonsPopGame.Srs.Command
{
    using Boards;
    using Printers;

    /// <summary>
    /// Restarts a command.
    /// </summary>
    public class RestartCommand : IInputCommand
    {
        private readonly Board board;
        private readonly IPrinterManager printer;

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
