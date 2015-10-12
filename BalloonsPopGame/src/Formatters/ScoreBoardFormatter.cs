// <copyright file="ScoreBoardFormatter.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Formatters
{
    /// <summary>
    /// Initialize a score board formatter.
    /// </summary>
    internal class ScoreBoardFormatter : IFormatter
    {
        /// <summary>
        /// Format a score board.
        /// </summary>
        /// <param name="number">Number of score board rows.</param>
        /// <param name="name">Name of player.</param>
        /// <param name="value">Player point value.</param>
        /// <returns>Formatter row of score board.</returns>
        public string Format(int number, string name, int value)
        {
            return string.Format("{0}.   {1} with {2} moves.", number, name, value);
        }
    }
}
