namespace BalloonsPopGame.Srs
{
    using System;

    /// <summary>
    /// Initialize the logic of the game.
    /// </summary>
    public class GameLogic
    {
        /// <summary>
        /// Initialize the directions for the game.
        /// </summary>
        private static readonly int[,] Direction = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
        
        /// <summary>
        /// Checks if given cell on the play board is empty.
        /// </summary>
        /// <param name="currentPlayBoard">Play board parameter.</param>
        /// <param name="row">Row of the cell for checking.</param>
        /// <param name="column">Column of the cell for checking.</param>
        /// <returns>Returns true or false according to the check.</returns>
        public bool CheckIfEmpty(char[,] currentPlayBoard, int row, int column)
        {
            return currentPlayBoard[row, column] == '0';
        }

        /// <summary>
        /// Pops the balloons linked to given position.
        /// </summary>
        /// <param name="currentPlayBoard">Play board parameter.</param>
        /// <param name="row">Row value of the given cell.</param>
        /// <param name="column">Column value of the given cell.</param>
        public void PopBaloons(char[,] currentPlayBoard, int row, int column)
        {
            var searchedBaloon = currentPlayBoard[row, column];
            currentPlayBoard[row, column] = '0';

            for (var i = 0; i < Direction.GetLength(0); i++)
            {
                PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedBaloon, Direction[i, 0], Direction[i, 1]);
            }
        }

        /// <summary>
        /// Pops the appropriate balloons in all directions of a given cell.
        /// </summary>
        /// <param name="currentPlayBoard">Play board parameter.</param>
        /// <param name="row">Row value of given cell.</param>
        /// <param name="column">Column value of given cell.</param>
        /// <param name="searchedTarget">Searched balloon value for pop
        /// .</param>
        /// <param name="directionX">Value of vertical direction.</param>
        /// <param name="directionY">Value of horizontal direction.</param>
        private static void PopBaloonsInAllDirections(char[,] currentPlayBoard, int row, int column, char searchedTarget, int directionX, int directionY)
        {
            row += directionX;
            column += directionY;
            try
            {
                if (currentPlayBoard[row, column] != searchedTarget)
                {
                    return;
                }

                currentPlayBoard[row, column] = '0';
                PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedTarget, directionX, directionY);
            }
            catch (IndexOutOfRangeException)
            {
            }
        }
    }
}
