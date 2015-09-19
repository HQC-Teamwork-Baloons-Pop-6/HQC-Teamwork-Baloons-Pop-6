namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;

    internal class BalloonsPopsGame
    {
        private const byte ScoreBoardRows = 5;
        private const byte ScoreBoardCols = 2;
        private const byte PlayBoardRows = 5;
        private const byte PlayBoardCols = 10;

        private static void Main()
        {
            string[,] topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];

            byte[,] playBoard = BoardGenerator.GenerateBoard(PlayBoardRows, PlayBoardCols);
            PrintingManager.PrintMatrix(playBoard);

            GameEngine engine = new GameEngine();
            engine.Start(topFivePlayers, playBoard);

            Console.WriteLine("Good Bye! ");
        }
    }
}