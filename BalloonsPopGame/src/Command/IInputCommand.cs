// <copyright file="IInputCommand.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Command
{
    /// <summary>
    /// Interface of input commands.
    /// </summary>
    public interface IInputCommand
    {
        /// <summary>
        /// Execute a input command.
        /// </summary>
        /// <param name="playBoard">Current play board.</param>
        /// <param name="playerMoves">Value of player moves.</param>
        void Execute(ref char[,] playBoard, ref int playerMoves);
    }
}
