namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;
    using BalloonsPopGame.Srs.Manufacturers;
    using BalloonsPopGame.Srs.Products;

    internal class GameStart
    {
        private const byte ScoreBoardRows = 5;
        private const byte ScoreBoardCols = 2;
        private const byte PlayBoardRows = 5;
        private const byte PlayBoardCols = 10;

        private static void Main()
        {
            string[,] topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];
            //Factory Method
            //Manufacturer manufacturer = new TelerikSoft();
            //char[,] playBoard = manufacturer.GenerateBoard();
            Board board = new Board(PlayBoardRows, PlayBoardCols);
            char[,] playBoard = board.GenerateBoard();

            //Singleton
            var log = PrintingManager.Instance;
            log.PrintMatrix(playBoard);
            
            GameEngine engine = new GameEngine();
            engine.Start(topFivePlayers, playBoard);

            Console.WriteLine("Good Bye! ");
        }
    }
}