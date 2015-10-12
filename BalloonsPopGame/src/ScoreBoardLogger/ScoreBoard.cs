namespace BalloonsPopGame.Srs.ScoreBoardLogger
{
    using System.Collections.Generic;
    using Formatters;

    /// <summary>
    /// Initialize a score board.
    /// </summary>
    public class ScoreBoard
    {
        /// <summary>
        /// Instance of logger.
        /// </summary>
        internal readonly ILogger Logger;

        /// <summary>
        /// Count of top players.
        /// </summary>
        private const byte CountOfTopPlayers = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreBoard"/> class.
        /// </summary>
        internal ScoreBoard()
        {
            this.Logger = new ConsoleLogger(new ScoreBoardFormatter());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreBoard"/> class.
        /// </summary>
        /// <param name="logger">Given logger value.</param>
        internal ScoreBoard(ILogger logger)
        {
            this.Logger = logger;
        }

        /// <summary>
        /// Prints the top players of the score board.
        /// </summary>
        /// <param name="playersTable">Top players parameter.</param>
        public void PrintTopPlayers(string[,] playersTable)
        {
            var finalScore = new List<Player>();

            for (int i = 0; i < CountOfTopPlayers; ++i)
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
