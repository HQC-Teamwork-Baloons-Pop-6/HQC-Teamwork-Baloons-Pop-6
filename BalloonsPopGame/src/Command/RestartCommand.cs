namespace BalloonsPopGame.Srs.Command
{
    using System;
    using Boards;

    public class RestartCommand : IInputCommand
    {
        private readonly Board _board;
        private readonly IPrinterManager _printer;

        public RestartCommand(Board board, IPrinterManager printer)
        {
            _board = board;
            _printer = printer;
        }

        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            playBoard = _board.GenerateBoard();
            _printer.PrintPlayBoard(playBoard);
            userMoves = 0;
        }
    }
}
