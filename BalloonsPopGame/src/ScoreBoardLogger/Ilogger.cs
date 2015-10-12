namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface of logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs given scores.
        /// </summary>
        /// <param name="scores">Given final scores for logging.</param>
        void Log(List<Player> scores);
    }
}
