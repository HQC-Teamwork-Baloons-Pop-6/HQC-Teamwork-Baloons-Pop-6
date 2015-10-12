// <copyright file="PlayCommand.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Command
{
    using System;
    using Boards;
    using Printers;
    using ScoreBoardLogger;
    using Validators;

    /// <summary>
    /// Process play command.
    /// </summary>
    public class PlayCommand : IInputCommand
    {
        /// <summary>
        /// Command value.
        /// </summary>
        private readonly string currentCommand;

        /// <summary>
        /// Top players value.
        /// </summary>
        private readonly string[,] topPlayers;

        /// <summary>
        /// Score board value.
        /// </summary>
        private readonly ScoreBoard scoreBoard;

        /// <summary>
        /// Board type.
        /// </summary>
        private readonly Board board;

        /// <summary>
        /// Printer value.
        /// </summary>
        private readonly IPrinterManager printer;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayCommand"/> class.
        /// </summary>
        /// <param name="currentCommand">Given command.</param>
        /// <param name="topPlayers">Top players of the game.</param>
        /// <param name="scoreBoard">Current score board.</param>
        /// <param name="board">Current play board.</param>
        /// <param name="printer">Given printer.</param>
        public PlayCommand(string currentCommand, string[,] topPlayers, ScoreBoard scoreBoard, Board board, IPrinterManager printer)
        {
            this.currentCommand = currentCommand;
            this.topPlayers = topPlayers;
            this.scoreBoard = scoreBoard;
            this.board = board;
            this.printer = printer;
        }

        //// TODO: Remove magic values and make them better formated
        
        /// <summary>
        /// Execute a play command.
        /// </summary>
        /// <param name="playBoard">Current play board.</param>
        /// <param name="playerMoves">Value of player moves.</param>
        public void Execute(ref char[,] playBoard, ref int playerMoves)
        {
            var userRow = int.Parse(this.currentCommand[0].ToString());
            if (userRow > playBoard.GetLength(0) - 1)
            {
                Console.WriteLine("Wrong input ! Try Again ! ");
                return;
            }

            var userColumn = int.Parse(this.currentCommand[2].ToString());

            var gameLogic = new GameLogic();

            if (gameLogic.CheckIfEmpty(playBoard, userRow, userColumn))
            {
                Console.WriteLine("cannot pop missing ballon!");
                return;
            }

            gameLogic.PopBaloons(playBoard, userRow, userColumn);

            playerMoves++;

            var winner = new WinnerValidator();

            if (winner.CheckIfIsWinner(playBoard))
            {
                Console.WriteLine("Gratz ! You completed it in {0} moves.", playerMoves);
                if (winner.SignIfSkilled(this.topPlayers, playerMoves))
                {
                    this.scoreBoard.PrintTopPlayers(this.topPlayers);
                }
                else
                {
                    Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                }

                playBoard = this.board.GenerateBoard();
                playerMoves = 0;
            }

            this.printer.PrintPlayBoard(playBoard);
        }
    }
}
