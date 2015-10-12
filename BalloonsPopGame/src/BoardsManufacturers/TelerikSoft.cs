// <copyright file="TelerikSoft.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.BoardsManufacturers
{
    using Boards;

    /// <summary>
    /// Creates new custom board.
    /// </summary>
    public class TelerikSoft : Manufacturer
    {
        /// <summary>
        /// Initialize new board with size 10 to 10.
        /// </summary>
        /// <returns>Returns created board.</returns>
        public override char[,] GenerateBoard()
        {
            var board = new Board10X10();
            return board.GenerateBoard();
        }
    }
}
