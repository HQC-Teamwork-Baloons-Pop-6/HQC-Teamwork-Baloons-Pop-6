// <copyright file="ILogger.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
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
