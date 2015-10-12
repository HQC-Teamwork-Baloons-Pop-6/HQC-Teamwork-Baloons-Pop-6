// <copyright file="IPrinterManager.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Printers
{
    /// <summary>
    /// Interface for the printer manager.
    /// </summary>
    public interface IPrinterManager
    {
        /// <summary>
        /// Prints a play board.
        /// </summary>
        /// <param name="playBoard">Play board for printing.</param>
        void PrintPlayBoard(char[,] playBoard);
    }
}
