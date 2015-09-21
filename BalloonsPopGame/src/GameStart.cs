namespace BalloonsPopGame.Srs
{
    using System;

    internal class GameStart
    {
        private static void Main()
        {
            GameEngine engine = new GameEngine();
            engine.Start();

            Console.WriteLine("Good Bye! ");
        }
    }
}