namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Formatters;

    /// <summary>
    /// Creates file logger.
    /// </summary>
    public class FileLogger : ILogger
    {
        /// <summary>
        /// Instance of formatter.
        /// </summary>
        internal readonly IFormatter Formatter;

        /// <summary>
        /// File path for logging data.
        /// </summary>
        private readonly string filePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileLogger"/> class.
        /// </summary>
        /// <param name="filePath">File path for logging.</param>
        /// <param name="formatter">Given value for formatter.</param>
        internal FileLogger(string filePath, IFormatter formatter)
        {
            this.filePath = filePath;
            this.Formatter = formatter;
        }

        /// <summary>
        /// Logs data to file.
        /// </summary>
        /// <param name="finalScore">Given data for logging.</param>
        public void Log(List<Player> finalScore)
        {
            Console.WriteLine("Scoreboard printed in file scoreboard.txt");
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0}", DateTime.Now));
            result.AppendLine("---------TOP FIVE CHART-----------");

            for (int i = 0; i < finalScore.Count; ++i)
            {
                var player = finalScore[i];
                result.AppendLine(this.Formatter.Format(i + 1, player.Name, player.Value));
            }

            result.AppendLine("----------------------------------");

            File.AppendAllText(this.filePath, result.ToString());
        }
    }
}
