namespace BalloonsPopGame.Srs.Command
{
    using BalloonsPopGame.Srs.ScoreBoardLogger;
    using System;

    internal class TopCommand : IInputCommand
    {
        private ScoreBoard scoreBoard;
        private string[,] topFive;

        public TopCommand(ScoreBoard scoreBoard, string[,] topFive)
        {
            this.scoreBoard = scoreBoard;
            this.topFive = topFive;
        }
        public void Execute()
        {
            this.scoreBoard.PrintTopFive(this.topFive);
        }
    }
}
