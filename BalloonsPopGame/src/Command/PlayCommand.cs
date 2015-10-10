namespace BalloonsPopGame.Srs.Command
{
    using System;
    using Boards;
    using Printers;
    using ScoreBoardLogger;
    using Validators;

    /// <summary>
    /// Process commands of the player.
    /// </summary>
    public class PlayCommand : IInputCommand
    {
        private readonly string currentCommand;
        private readonly string[,] topFive;
        private readonly ScoreBoard scoreBoard;
        private readonly Board board;
        private readonly IPrinterManager printer;

        public PlayCommand(string currentCommand, string[,] topFive, ScoreBoard scoreBoard, Board board, IPrinterManager printer)
        {
            this.currentCommand = currentCommand;
            this.topFive = topFive;
            this.scoreBoard = scoreBoard;
            this.board = board;
            this.printer = printer;
        }

        ////TODO: Remove magic values and make them better formated
        public void Execute(ref char[,] playBoard, ref int userMoves)
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

            userMoves++;

            var winner = new WinnerValidator();

            if (winner.CheckIfIsWinner(playBoard))
            {
                Console.WriteLine("Gratz ! You completed it in {0} moves.", userMoves);
                if (winner.SignIfSkilled(this.topFive, userMoves))
                {
                    this.scoreBoard.PrintTopFive(this.topFive);
                }
                else
                {
                    Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                }

                playBoard = this.board.GenerateBoard();
                userMoves = 0;
            }

            this.printer.PrintPlayBoard(playBoard);
        }
    }
}
