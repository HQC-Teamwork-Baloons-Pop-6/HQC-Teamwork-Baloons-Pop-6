namespace BalloonsPopGame.Srs.Command
{
    using ScoreBoardLogger;

    /// <summary>
    /// Process a top command.
    /// </summary>
    public class TopCommand : IInputCommand
    {
        private readonly ScoreBoard scoreBoard;
        private readonly string[,] topFive;

        public TopCommand(ScoreBoard scoreBoard, string[,] topFive)
        {
            this.scoreBoard = scoreBoard;
            this.topFive = topFive;
        }

        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            this.scoreBoard.PrintTopFive(this.topFive);
        }
    }
}
