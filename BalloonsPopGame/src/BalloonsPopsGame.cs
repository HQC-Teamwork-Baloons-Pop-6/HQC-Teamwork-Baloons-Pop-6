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
            byte[,] boardMatrix = MatrixGenerator.GenerateMatrix(PlayBoardRows, PlayBoardCols);
            PrintingManager.PrintMatrix(boardMatrix);

            GameEngine engine = new GameEngine();
            engine.Start(topFivePlayers, boardMatrix);

            Console.WriteLine("Good Bye! ");
        }
    }
}