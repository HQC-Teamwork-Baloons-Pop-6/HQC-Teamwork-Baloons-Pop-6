namespace BalloonsPopGame.Srs.Command
{
    using ScoreBoardLogger;

    public class TopCommand : IInputCommand
    {
        private readonly ScoreBoard _scoreBoard;
        private readonly string[,] _topFive;

        public TopCommand(ScoreBoard scoreBoard, string[,] topFive)
        {
            this._scoreBoard = scoreBoard;
            this._topFive = topFive;
        }

        public void Execute(ref char[,] playBoard, ref int userMoves)
        {
            this._scoreBoard.PrintTopFive(this._topFive);
        }
    }
}
