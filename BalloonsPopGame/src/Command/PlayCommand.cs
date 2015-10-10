namespace BalloonsPopGame.Srs.Command
{
    using System;
    using Boards;
    using ScoreBoardLogger;
    using Validators;

    public class PlayCommand : IInputCommand
    {
        private readonly string _currentCommand;
        private readonly string[,] _topFive;
        private readonly ScoreBoard _scoreBoard;
        private readonly Board _board;
        private readonly IPrinterManager _printer;

        public PlayCommand(string currentCommand, string[,] topFive, ScoreBoard scoreBoard, Board board, IPrinterManager printer)
        {
            _currentCommand = currentCommand;
            _topFive = topFive;
            _scoreBoard = scoreBoard;
            _board = board;
            _printer = printer;
        }

        //TODO: Remove magic values and make them better formated
        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            var userRow = int.Parse(this._currentCommand[0].ToString());
            if (userRow > playBoard.GetLength(0) - 1)
            {
                Console.WriteLine("Wrong input ! Try Again ! ");
                return;
            }

            var userColumn = int.Parse(this._currentCommand[2].ToString());

            var gameLogic = new GameLogic();

            if (gameLogic.CheckIfEmpty(playBoard, userRow, userColumn))
            {
                Console.WriteLine("cannot pop missing ballon!");
                return;
            }

            gameLogic.PopBaloons(playBoard, userRow, userColumn);

            userMoves++;

            var winner = new WinnerValidator();

            if (winner.CheckIfIsWinner(playBoard))
            {
                Console.WriteLine("Gratz ! You completed it in {0} moves.", userMoves);
                if (winner.SignIfSkilled(_topFive, userMoves))
                {
                    _scoreBoard.PrintTopFive(_topFive);
                }
                else
                {
                    Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                }

                playBoard = _board.GenerateBoard();
                userMoves = 0;
            }

            _printer.PrintPlayBoard(playBoard);
        }
    }
}
