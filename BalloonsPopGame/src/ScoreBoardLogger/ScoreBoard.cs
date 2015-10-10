namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System.Collections.Generic;
    using Formatters;

    public class ScoreBoard
    {
        internal readonly ILogger Logger;
        private const byte TopFive = 5;

        internal ScoreBoard()
        {
            Logger = new ConsoleLogger(new ScoreBoardFormatter());
        }

        internal ScoreBoard(ILogger logger)
        {
            Logger = logger;
        }

        public void PrintTopFive(string[,] playersTable)
        {
            var finalScore = new List<Player>();

            for (int i = 0; i < TopFive; ++i)
            {
                if (playersTable[i, 0] == null)
                {
                    break;
                }

                finalScore.Add(new Player(int.Parse(playersTable[i, 0]), playersTable[i, 1]));
            }

            finalScore.Sort();
            Logger.Log(finalScore);
        }
    }
}
