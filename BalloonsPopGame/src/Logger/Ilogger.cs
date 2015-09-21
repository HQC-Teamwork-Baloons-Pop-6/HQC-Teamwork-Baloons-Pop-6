namespace BalloonsPopGame.Srs.Logger
{
    using System.Collections.Generic;

    public interface ILogger
    {
        void Log(List<Player> finalScore);
    }
}
