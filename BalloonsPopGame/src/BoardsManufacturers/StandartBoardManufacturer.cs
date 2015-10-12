// <copyright file="StandartBoardManufacturer.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    /// <summary>
    /// Creates a standard board.
    /// </summary>
    public class StandartBoardManufacturer : Manufacturer
    {
        /// <summary>
        /// Generates new board.
        /// </summary>
        /// <returns>Returns the generated board.</returns>
        public override char[,] GenerateBoard()
        {
            var board = new Board5X10();
            return board.GenerateBoard();
        }
    }
}
