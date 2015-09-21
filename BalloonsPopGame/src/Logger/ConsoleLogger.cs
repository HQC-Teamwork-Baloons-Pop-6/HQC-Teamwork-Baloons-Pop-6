namespace BalloonsPopGame.Srs.Logger
{
    using System;
    using System.Collections.Generic;
    using BalloonsPopGame.Srs.Formatters;

    public class ConsoleLogger : ILogger
    {
        internal readonly IFormatter Formatter;

        internal ConsoleLogger(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public void Log(List<Player> finalScore)
        {
            Console.WriteLine("---------TOP FIVE CHART-----------");
            for (int i = 0; i < finalScore.Count; ++i)
            {
                Player player = finalScore[i];
                Console.WriteLine(this.Formatter.Format(i + 1, player.Name, player.Value));
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
