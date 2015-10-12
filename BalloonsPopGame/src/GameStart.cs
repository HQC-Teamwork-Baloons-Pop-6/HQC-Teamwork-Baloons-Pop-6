namespace BalloonsPopGame.Srs
{
    using System;

    /// <summary>
    /// Initialize a game start.
    /// </summary>
    internal class GameStart
    {
        /// <summary>
        /// Main method of the class.
        /// </summary>
        internal static void Main()
        {
            var engine = new GameEngine();
            engine.Start();

            Console.WriteLine("Good Bye! ");
        }
    }
}