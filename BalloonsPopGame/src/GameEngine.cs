// <copyright file="GameEngine.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs
{
    using System;
    using Boards;
    using Printers;

    /// <summary>
    /// Initialize the engine of the game.
    /// </summary>
    public class GameEngine
    {
        /// <summary>
        /// Sizes of the play board.
        /// </summary>
        private readonly byte[] playBoardLenghts = { 5, 10 };

        /// <summary>
        /// Sizes of the score board.
        /// </summary>
        private readonly byte[] scoreBoardLenghts = { 5, 2 };
        
        /// <summary>
        /// Initialize the start of the game engine.
        /// </summary>
        public void Start()
        {
            // Factory Method
            // Manufacturer manufacturer = new TelerikSoft();
            // char[,] playBoard = manufacturer.GenerateBoard();
            var board = new Board(this.playBoardLenghts[0], this.playBoardLenghts[1]);
            var playBoard = board.GenerateBoard();

            // Singleton
            var printer = PrintingManager.Instance;
            printer.PrintPlayBoard(playBoard);

            var topFivePlayers = new string[this.scoreBoardLenghts[0], this.scoreBoardLenghts[1]];
            string currentCommand = null;
            var userMoves = 0;
            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                if (string.IsNullOrEmpty(currentCommand) || string.IsNullOrWhiteSpace(currentCommand))
                {
                    continue;
                }

                currentCommand = currentCommand.ToUpper().Trim();

                var gameCommand = new GameCommandsEngine(currentCommand, topFivePlayers);
                gameCommand.ProcessGame(ref playBoard, ref userMoves);
            }
        }
    }
}
