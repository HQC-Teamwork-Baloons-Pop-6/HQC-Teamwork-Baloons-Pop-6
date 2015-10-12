namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    public interface IScoreBoard
    {
        void PrintTopFive(string[,] playersTable);
    }
}