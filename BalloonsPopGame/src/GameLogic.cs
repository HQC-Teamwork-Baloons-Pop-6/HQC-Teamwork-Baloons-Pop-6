namespace BalloonsPopGame.Srs
{
    using System;

    public abstract class GameLogic
    {
        public static bool CheckIfEmptyElseChangeCurrentPlayBoard(char[,] currentPlayBoard, int rowAtm, int columnAtm)
        {
            if (currentPlayBoard[rowAtm, columnAtm] == '0')
            {
                return true;
            }

            char searchedTarget = currentPlayBoard[rowAtm, columnAtm];
            currentPlayBoard[rowAtm, columnAtm] = '0';

            CheckLeft(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckRight(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckUp(currentPlayBoard, rowAtm, columnAtm, searchedTarget);
            CheckDown(currentPlayBoard, rowAtm, columnAtm, searchedTarget);

            return false;
        }

        private static void CheckLeft(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row;
            int newColumn = column - 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckLeft(matrix, newRow, newColumn, searchedItem);
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

        private static void CheckRight(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row;
            int newColumn = column + 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckRight(matrix, newRow, newColumn, searchedItem);
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

        private static void CheckUp(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row + 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckUp(matrix, newRow, newColumn, searchedItem);
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

        private static void CheckDown(char[,] matrix, int row, int column, char searchedItem)
        {
            int newRow = row - 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = '0';
                    CheckDown(matrix, newRow, newColumn, searchedItem);
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
