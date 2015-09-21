namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;
    using BalloonsPopGame.Srs.Logger;

    internal class ScoreBoard
    {
        internal readonly ILogger Logger;

        internal ScoreBoard(ILogger logger)
        {
            this.Logger = logger;
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
            this.Logger.Log(finalScore);
        }
    }
}
