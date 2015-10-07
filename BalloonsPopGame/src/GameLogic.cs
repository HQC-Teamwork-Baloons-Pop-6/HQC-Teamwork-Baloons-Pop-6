namespace BalloonsPopGame.Srs
{
    using System;

    public abstract class GameLogic
    {
        private static int[,] Direction = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };

        // TODO separate two methods IfIsEmpty and ModifyCurrentPlayboard
        public static bool CheckIfEmptyElseChangeCurrentPlayBoard(char[,] currentPlayBoard, int row, int column)
        {
            if (currentPlayBoard[row, column] == '0')
            {
                return true;
            }

            char searchedBaloon = currentPlayBoard[row, column];
            currentPlayBoard[row, column] = '0';

            for (int i = 0; i < Direction.GetLength(0); i++)
            {
                ChechDirections(currentPlayBoard, row, column, searchedBaloon, Direction[i, 0], Direction[i, 1]);
            }

            return false;
        }

        private static void ChechDirections(char[,] currentPlayBoard, int row, int column, char searchedTarget, int directionX, int directionY)
        {
            row += directionX;
            column += directionY;
            try
            {
                if (currentPlayBoard[row, column] == searchedTarget)
                {
                    currentPlayBoard[row, column] = '0';
                    ChechDirections(currentPlayBoard, row, column, searchedTarget, directionX, directionY);
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
