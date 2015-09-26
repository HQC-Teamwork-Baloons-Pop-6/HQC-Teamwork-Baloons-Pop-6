namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System.Collections.Generic;

    public interface ILogger
    {
        void Log(List<Player> finalScore);
    }
}
