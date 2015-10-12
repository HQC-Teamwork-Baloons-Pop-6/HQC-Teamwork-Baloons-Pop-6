// <copyright file="GameStart.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
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