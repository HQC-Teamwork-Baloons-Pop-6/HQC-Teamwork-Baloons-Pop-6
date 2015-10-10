namespace BalloonsPopGame.Srs
{
    using System;
    using Boards;

    public class GameEngine
    {
        private const byte ScoreBoardRows = 5;
        private const byte ScoreBoardCols = 2;
        private const byte PlayBoardRows = 5;
        private const byte PlayBoardCols = 10;

        public void Start()
        {
            // Factory Method
            // Manufacturer manufacturer = new TelerikSoft();
            // char[,] playBoard = manufacturer.GenerateBoard();
            var board = new Board(PlayBoardRows, PlayBoardCols);
            var playBoard = board.GenerateBoard();

            // Singleton
            var printer = PrintingManager.Instance;
            printer.PrintPlayBoard(playBoard);

            var topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];
            string currentCommand = null;
            var userMoves = 0;
            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                if (currentCommand == null) continue;
                currentCommand = currentCommand.ToUpper().Trim();

                var gameCommand = new GameCommandsEngine(currentCommand, topFivePlayers);
                gameCommand.ProcessGame(ref playBoard, ref userMoves);
            }
        }
    }
}
