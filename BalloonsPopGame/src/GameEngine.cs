namespace BalloonsPopGame.Srs
{
    using System;
    using BalloonsPopGame.Srs.Boards;

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
            Board board = new Board(PlayBoardRows, PlayBoardCols);
            char[,] playBoard = board.GenerateBoard();

            // Singleton
            var printer = PrintingManager.Instance;
            printer.PrintPlayBoard(playBoard);

            string[,] topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];
            string currentCommand = null;
            int userMoves = 0;
            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                currentCommand = currentCommand.ToUpper().Trim();

                GameCommandsEngine gameCommand = new GameCommandsEngine(currentCommand, topFivePlayers);
                gameCommand.ProcessGame(ref playBoard, ref userMoves);
            }
        }
    }
}
