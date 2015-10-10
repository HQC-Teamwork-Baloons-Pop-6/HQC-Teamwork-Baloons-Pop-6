namespace BalloonsPopGame.Srs
{
    using System;

    public class GameLogic
    {
        private static readonly int[,] Direction = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
               
        public bool CheckIfEmpty(char[,] currentPlayBoard, int row, int column)
        {
            return currentPlayBoard[row, column] == '0';
        }

        public void PopBaloons(char[,] currentPlayBoard, int row, int column)
        {
            var searchedBaloon = currentPlayBoard[row, column];
            currentPlayBoard[row, column] = '0';

            for (var i = 0; i < Direction.GetLength(0); i++)
            {
                PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedBaloon, Direction[i, 0], Direction[i, 1]);
            }
        }

        private static void PopBaloonsInAllDirections(char[,] currentPlayBoard, int row, int column, char searchedTarget, int directionX, int directionY)
        {
            row += directionX;
            column += directionY;
            try
            {
                if (currentPlayBoard[row, column] != searchedTarget) return;
                currentPlayBoard[row, column] = '0';
                PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedTarget, directionX, directionY);
            }
            catch (IndexOutOfRangeException)
            {
            }
        }
    }
}
