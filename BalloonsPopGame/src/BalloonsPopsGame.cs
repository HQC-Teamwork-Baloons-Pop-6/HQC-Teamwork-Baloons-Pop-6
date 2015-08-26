namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;

    internal class BalloonsPopsGame
    {
        private static void CheckLeft(byte[,] matrix, int row, int column, int searchedItem)
        {
            int newRow = row;
            int newColumn = column - 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = 0;
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

        private static void CheckRight(byte[,] matrix, int row, int column, int searchedItem)
        {
            int newRow = row;
            int newColumn = column + 1;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = 0;
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

        private static void CheckUp(byte[,] matrix, int row, int column, int searchedItem)
        {
            int newRow = row + 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = 0;
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

        private static void CheckDown(byte[,] matrix, int row, int column, int searchedItem)
        {
            int newRow = row - 1;
            int newColumn = column;
            try
            {
                if (matrix[newRow, newColumn] == searchedItem)
                {
                    matrix[newRow, newColumn] = 0;
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

        private static bool Change(byte[,] matrixToModify, int rowAtm, int columnAtm)
        {
            if (matrixToModify[rowAtm, columnAtm] == 0)
            {
                return true;
            }

            byte searchedTarget = matrixToModify[rowAtm, columnAtm];
            matrixToModify[rowAtm, columnAtm] = 0;
            CheckLeft(matrixToModify, rowAtm, columnAtm, searchedTarget);
            CheckRight(matrixToModify, rowAtm, columnAtm, searchedTarget);

            CheckUp(matrixToModify, rowAtm, columnAtm, searchedTarget);
            CheckDown(matrixToModify, rowAtm, columnAtm, searchedTarget);
            return false;
        }

        private static bool CheckIfIsWinner(byte[,] matrix)
        {
            bool isWinner = true;
            Stack<byte> stek = new Stack<byte>();
            int columnLenght = matrix.GetLength(0);
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < columnLenght; i++)
                {
                    if (matrix[i, j] != 0)
                    {
                        isWinner = false;
                        stek.Push(matrix[i, j]);
                    }
                }

                for (int k = columnLenght - 1; k >= 0; k--)
                {
                    try
                    {
                        matrix[k, j] = stek.Pop();
                    }
                    catch (Exception)
                    {
                        matrix[k, j] = 0;
                    }
                }
            }

            return isWinner;
        }

        private static void SortAndPrintChartFive(string[,] tableToSort)
        {
            List<Gamer> finalScore = new List<Gamer>();

            for (int i = 0; i < 5; ++i)
            {
                if (tableToSort[i, 0] == null)
                {
                    break;
                }

                finalScore.Add(new Gamer(int.Parse(tableToSort[i, 0]), tableToSort[i, 1]));
            }

            finalScore.Sort();
            Console.WriteLine("---------TOP FIVE CHART-----------");
            for (int i = 0; i < finalScore.Count; ++i)
            {
                Gamer slot = finalScore[i];
                Console.WriteLine("{2}.   {0} with {1} moves.", slot.Name, slot.Value, i + 1);
            }

            Console.WriteLine("----------------------------------");
        }

        private static bool SignIfSkilled(string[,] chart, int points)
        {
            bool skilled = false;
            int worstMoves = 0;
            int worstMovesChartPosition = 0;
            for (int i = 0; i < 5; i++)
            {
                if (chart[i, 0] == null)
                {
                    Console.WriteLine("Type in your name.");
                    string tempUserName = Console.ReadLine();
                    chart[i, 0] = points.ToString();
                    chart[i, 1] = tempUserName;
                    skilled = true;
                    break;
                }
            }

            if (skilled == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (int.Parse(chart[i, 0]) > worstMoves)
                    {
                        worstMovesChartPosition = i;
                        worstMoves = int.Parse(chart[i, 0]);
                    }
                }
            }

            if (points < worstMoves && skilled == false)
            {
                Console.WriteLine("Type in your name.");
                string tempUserName = Console.ReadLine();
                chart[worstMovesChartPosition, 0] = points.ToString();
                chart[worstMovesChartPosition, 1] = tempUserName;
                skilled = true;
            }

            return skilled;
        }

        private static void Main(string[] args)
        {
            string[,] topFive = new string[5, 2];
            byte[,] matrix = MatrixGenerator.GenerateMatrix(5, 10);

            PrintingManager.PrintMatrix(matrix);
            string temp = null;
            int userMoves = 0;
            while (temp != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                temp = Console.ReadLine();
                temp = temp.ToUpper().Trim();

                ProcessGame(temp, topFive, ref matrix, ref userMoves);
            }

            Console.WriteLine("Good Bye! ");
        }

        private static void ProcessGame(string temp, string[,] topFive, ref byte[,] matrix, ref int userMoves)
        {
            switch (temp)
            {
                case "RESTART":
                    matrix = MatrixGenerator.GenerateMatrix(5, 10);
                    PrintingManager.PrintMatrix(matrix);
                    userMoves = 0;
                    break;

                case "TOP":
                    SortAndPrintChartFive(topFive);
                    break;

                default:
                    if ((temp.Length == 3) && (temp[0] >= '0' && temp[0] <= '9') && (temp[2] >= '0' && temp[2] <= '9') && (temp[1] == ' ' || temp[1] == '.' || temp[1] == ','))
                    {
                        int userRow, userColumn;
                        userRow = int.Parse(temp[0].ToString());
                        if (userRow > 4)
                        {
                            Console.WriteLine("Wrong input ! Try Again ! ");
                            return;
                        }

                        userColumn = int.Parse(temp[2].ToString());

                        if (Change(matrix, userRow, userColumn))
                        {
                            Console.WriteLine("cannot pop missing ballon!");
                            return;
                        }

                        userMoves++;
                        if (CheckIfIsWinner(matrix))
                        {
                            Console.WriteLine("Gratz ! You completed it in {0} moves.", userMoves);
                            if (SignIfSkilled(topFive, userMoves))
                            {
                                SortAndPrintChartFive(topFive);
                            }
                            else
                            {
                                Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                            }

                            matrix = MatrixGenerator.GenerateMatrix(5, 10);
                            userMoves = 0;
                        }

                        PrintingManager.PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input ! Try Again ! ");
                        break;
                    }
            }
        }
    }
}