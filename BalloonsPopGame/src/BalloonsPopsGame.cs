namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;
    using BalloonsPopGame.Srs.Manufacturers;
    using BalloonsPopGame.Srs.Products;

    internal class BalloonsPopsGame
    {
        private const byte ScoreBoardRows = 5;
        private const byte ScoreBoardCols = 2;
        private const byte PlayBoardRows = 5;
        private const byte PlayBoardCols = 10;

        private static void Main()
        {
            string[,] topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];
            //Manufacturer manufacturer = new TelerikSoft();
            //byte[,] playBoard = manufacturer.GenerateBoard();
            Board board = new Board(PlayBoardRows, PlayBoardCols);
            byte[,] playBoard = board.GenerateBoard();
            PrintingManager.PrintMatrix(playBoard);

            GameEngine engine = new GameEngine();
            engine.Start(topFivePlayers, playBoard);

            Console.WriteLine("Good Bye! ");
        }
    }
}