// <copyright file="ConsoleLogger.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System;
    using System.Collections.Generic;
    using Formatters;

    /// <summary>
    /// Creates console loggers.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Instance of formatter.
        /// </summary>
        internal readonly IFormatter Formatter;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
        /// </summary>
        /// <param name="formatter">Given formatter for creating.</param>
        internal ConsoleLogger(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        /// <summary>
        /// Logs a given final score.
        /// </summary>
        /// <param name="finalScore">Value of final score for logging.</param>
        public void Log(List<Player> finalScore)
        {
            Console.WriteLine("---------TOP FIVE CHART-----------");
            for (int i = 0; i < finalScore.Count; ++i)
            {
                var player = finalScore[i];
                Console.WriteLine(this.Formatter.Format(i + 1, player.Name, player.Value));
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
