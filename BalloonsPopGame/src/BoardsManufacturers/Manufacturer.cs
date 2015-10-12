// <copyright file="Manufacturer.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    /// <summary>
    /// Initialize a manufacturer.
    /// </summary>
    public abstract class Manufacturer
    {
        /// <summary>
        /// Generate a board.
        /// </summary>
        /// <returns>Returns the generated board.</returns>
        public abstract char[,] GenerateBoard();
    }
}
