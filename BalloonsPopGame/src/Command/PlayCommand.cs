namespace BalloonsPopGame.Srs.Command
{
    using System;
    using BalloonsPopGame.Srs.Boards;
    using BalloonsPopGame.Srs.ScoreBoardLogger;
    using BalloonsPopGame.Srs.Validators;

    public class PlayCommand : IInputCommand
    {
        private string currentCommand;
        private string[,] topFive;
        private ScoreBoard scoreBoard;
        private Board board;
        private IPrinterManager printer;

        public PlayCommand(string currentCommand, string[,] topFive, ScoreBoard scoreBoard, Board board, IPrinterManager printer)
        {
            this.currentCommand = currentCommand;
            this.topFive = topFive;
            this.scoreBoard = scoreBoard;
            this.board = board;
            this.printer = printer;
        }

        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            int userRow = int.Parse(this.currentCommand[0].ToString());
            if (userRow > playBoard.GetLength(0) - 1)
            {
                Console.WriteLine("Wrong input ! Try Again ! ");
                return;
            }

            int userColumn = int.Parse(this.currentCommand[2].ToString());
            if (GameLogic.CheckIfEmptyElseChangeCurrentPlayBoard(playBoard, userRow, userColumn))
            {
                Console.WriteLine("cannot pop missing ballon!");
                return;
            }

            userMoves++;
            if (Winner.CheckIfIsWinner(playBoard))
            {
                Console.WriteLine("Gratz ! You completed it in {0} moves.", userMoves);
                if (Winner.SignIfSkilled(this.topFive, userMoves))
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
