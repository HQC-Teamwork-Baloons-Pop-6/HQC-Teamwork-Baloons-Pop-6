namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using BalloonsPopGame.Srs.Formatters;

    public class FileLogger : ILogger
    {
        internal readonly IFormatter Formatter;
        private readonly string filePath;

        internal FileLogger(string filePath, IFormatter formatter)
        {
            this.filePath = filePath;
            this.Formatter = formatter;
        }

        public void Log(List<Player> finalScore)
        {
            Console.WriteLine("Scoreboard printed in file scoreboard.txt");
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0}", DateTime.Now));
            result.AppendLine("---------TOP FIVE CHART-----------");

            for (int i = 0; i < finalScore.Count; ++i)
            {
                Player player = finalScore[i];
                result.AppendLine(this.Formatter.Format(i + 1, player.Name, player.Value));
            }

            result.AppendLine("----------------------------------");

            File.AppendAllText(this.filePath, result.ToString());
        }
    }
}
