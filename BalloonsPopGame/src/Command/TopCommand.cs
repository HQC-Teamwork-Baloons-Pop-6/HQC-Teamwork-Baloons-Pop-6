// <copyright file="TopCommand.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Command
{
    using ScoreBoardLogger;

    /// <summary>
    /// Process a top command.
    /// </summary>
    public class TopCommand : IInputCommand
    {
        /// <summary>
        /// Score board instance.
        /// </summary>
        private readonly ScoreBoard scoreBoard;

        /// <summary>
        /// Current top players.
        /// </summary>
        private readonly string[,] topPlayers;

        /// <summary>
        /// Initializes a new instance of the <see cref="TopCommand"/> class.
        /// </summary>
        /// <param name="scoreBoard">Current score board value.</param>
        /// <param name="topPlayers">Current top players.</param>
        public TopCommand(ScoreBoard scoreBoard, string[,] topPlayers)
        {
            this.scoreBoard = scoreBoard;
            this.topPlayers = topPlayers;
        }

        /// <summary>
        /// Execute a top players command.
        /// </summary>
        /// <param name="playBoard">Current play board.</param>
        /// <param name="playerMoves">Current player moves.</param>
        public void Execute(ref char[,] playBoard, ref int playerMoves)
        {
            this.scoreBoard.PrintTopPlayers(this.topPlayers);
        }
    }
}
