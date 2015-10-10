namespace BalloonsPopGame.Srs
{
    using System;

    internal class GameStart
    {
        private static void Main()
        {
            var engine = new GameEngine();
            engine.Start();

            Console.WriteLine("Good Bye! ");
        }
    }
}