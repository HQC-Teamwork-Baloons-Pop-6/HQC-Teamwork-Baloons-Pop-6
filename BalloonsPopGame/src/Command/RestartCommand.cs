// <copyright file="RestartCommand.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Command
{
    using Boards;
    using Printers;

    /// <summary>
    /// Restarts a command.
    /// </summary>
    public class RestartCommand : IInputCommand
    {
        /// <summary>
        /// Instance of board.
        /// </summary>
        private readonly Board board;

        /// <summary>
        /// Instance of printer.
        /// </summary>
        private readonly IPrinterManager printer;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartCommand"/> class.
        /// </summary>
        /// <param name="board">Board value.</param>
        /// <param name="printer">Printer value.</param>
        public RestartCommand(Board board, IPrinterManager printer)
        {
            this.board = board;
            this.printer = printer;
        }

        /// <summary>
        /// Execute the restart command.
        /// </summary>
        /// <param name="playBoard">Current play board.</param>
        /// <param name="playerMoves">Current player moves.</param>
        public void Execute(ref char[,] playBoard, ref int playerMoves)
        {
            playBoard = this.board.GenerateBoard();
            this.printer.PrintPlayBoard(playBoard);
            playerMoves = 0;
        }
    }
}
