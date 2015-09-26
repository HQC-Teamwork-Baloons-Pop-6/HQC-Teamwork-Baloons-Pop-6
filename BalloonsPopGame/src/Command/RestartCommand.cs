namespace BalloonsPopGame.Srs.Command
{
    using BalloonsPopGame.Srs.Boards;

    public class RestartCommand : IInputCommand
    {
        private char[,] playBoard;
        private Board board;
        private IPrinterMenager printer;

        public RestartCommand(char[,] playBoard, Board board, IPrinterMenager printer)
        {
            this.playBoard = playBoard;
            this.board = board;
            this.printer = printer;
        }

        public void Execute()
        {
            this.playBoard = this.board.GenerateBoard();
            this.printer.PrintPlayBoard(this.playBoard);
        }
    }
}
