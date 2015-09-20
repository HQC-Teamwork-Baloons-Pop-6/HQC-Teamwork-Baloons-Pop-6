namespace BalloonsPopGame.Srs
{
    using BalloonsPopGame.Srs.Formatters;
    using System;
    using System.Collections.Generic;

    internal class ScoreBoard
    {
        internal readonly IFormatter Formatter;

        internal ScoreBoard(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public void PrintTopFive(string[,] playersTable)
        {
            List<Player> finalScore = new List<Player>();

            for (int i = 0; i < 5; ++i)
            {
                if (playersTable[i, 0] == null)
                {
                    break;
                }

                finalScore.Add(new Player(int.Parse(playersTable[i, 0]), playersTable[i, 1]));
            }

            finalScore.Sort();
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
