namespace BalloonsPopGame.Srs.Command
{
    using System;
    using BalloonsPopGame.Srs.Boards;
    using BalloonsPopGame.Srs.ScoreBoardLogger;
    using BalloonsPopGame.Srs.Validators;
    
    public class PlayCommand : IInputCommand
    {
        private string currentCommand;
        private int userMoves;
        private char[,] playBoard;
        private string[,] topFive;
        private ScoreBoard scoreBoard;
        private Board board;
        private IPrinterMenager printer;

        public PlayCommand(string currentCommand, int userMoves, char[,] playBoard, string[,] topFive, ScoreBoard scoreBoard, Board board, IPrinterMenager printer)
        {
            this.currentCommand = currentCommand;
            this.userMoves = userMoves;
            this.playBoard = playBoard;
            this.topFive = topFive;
            this.scoreBoard = scoreBoard;
            this.board = board;
            this.printer = printer;
        }

        public void Execute()
        {
            int userRow = int.Parse(this.currentCommand[0].ToString());
            if (userRow > this.playBoard.GetLength(0) - 1)
            {
                Console.WriteLine("Wrong input ! Try Again ! ");
                return;
            }

            int userColumn = int.Parse(this.currentCommand[2].ToString());
            if (GameLogic.CheckIfEmptyElseChangeCurrentPlayBoard(this.playBoard, userRow, userColumn))
            {
                Console.WriteLine("cannot pop missing ballon!");
                return;
            }

            this.userMoves++;
            if (Winner.CheckIfIsWinner(this.playBoard))
            {
                Console.WriteLine("Gratz ! You completed it in {0} moves.", this.userMoves);
                if (Winner.SignIfSkilled(this.topFive, this.userMoves))
                {
                    this.scoreBoard.PrintTopFive(this.topFive);
                }
                else
                {
                    Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                }

                this.playBoard = this.board.GenerateBoard();
                this.userMoves = 0;
            }
            this.printer.PrintPlayBoard(this.playBoard);
        }
    }
}
