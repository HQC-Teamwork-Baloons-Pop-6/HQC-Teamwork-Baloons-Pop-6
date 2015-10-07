namespace BalloonsPopGame.Srs
{
    using System;

    public class GameLogic
    {
        private static int[,] direction = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
               
        public bool CheckIfEmpty(char[,] currentPlayBoard, int row, int column)
        {
            if (currentPlayBoard[row, column] == '0')
            {
                return true;
            }

            return false;
        }

        public void PopBaloons(char[,] currentPlayBoard, int row, int column)
        {
            char searchedBaloon = currentPlayBoard[row, column];
            currentPlayBoard[row, column] = '0';

            for (int i = 0; i < direction.GetLength(0); i++)
            {
                this.PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedBaloon, direction[i, 0], direction[i, 1]);
            }
        }

        private void PopBaloonsInAllDirections(char[,] currentPlayBoard, int row, int column, char searchedTarget, int directionX, int directionY)
        {
            row += directionX;
            column += directionY;
            try
            {
                if (currentPlayBoard[row, column] == searchedTarget)
                {
                    currentPlayBoard[row, column] = '0';
                    this.PopBaloonsInAllDirections(currentPlayBoard, row, column, searchedTarget, directionX, directionY);
                }
                else
                {
                    return;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }
        }
    }
}
