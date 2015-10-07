namespace BalloonsPopGame.Srs.Validators
{
    using System;
    using System.Collections.Generic;

    public class WinnerValidator
    {
        public bool CheckIfIsWinner(char[,] playBoard)
        {
            bool isWinner = true;
            Stack<char> stek = new Stack<char>();

            int rowLenght = playBoard.GetLength(1);
            int columnLenght = playBoard.GetLength(0);
            for (int j = 0; j < rowLenght; j++)
            {
                for (int i = 0; i < columnLenght; i++)
                {
                    if (playBoard[i, j] != '0')
                    {
                        isWinner = false;
                        stek.Push(playBoard[i, j]);
                    }
                }

                for (int k = columnLenght - 1; k >= 0; k--)
                {
                    try
                    {
                        playBoard[k, j] = stek.Pop();
                    }
                    catch (Exception)
                    {
                        playBoard[k, j] = '0';
                    }
                }
            }

            return isWinner;
        }
               
        public bool SignIfSkilled(string[,] chart, int points)
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
    }
}
