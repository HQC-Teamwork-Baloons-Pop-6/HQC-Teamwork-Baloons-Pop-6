namespace BalloonsPopGame.Srs.Formatters
{
    /// <summary>
    /// Interface for formatter.
    /// </summary>
    internal interface IFormatter
    {
        /// <summary>
        /// Formats by given values.
        /// </summary>
        /// <param name="number">Number of row.</param>
        /// <param name="name">Name of player.</param>
        /// <param name="value">Points of player.</param>
        /// <returns>String formatted with given values.</returns>
        string Format(int number, string name, int value);
    }
}
