namespace BalloonsPopGame.Srs.Validators
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Validate winners.
    /// </summary>
    public class WinnerValidator
    {
        /// <summary>
        /// Check if the game is won.
        /// </summary>
        /// <param name="playBoard">Value of current play board state.</param>
        /// <returns>True of false if game is won.</returns>
        public bool CheckIfIsWinner(char[,] playBoard)
        {
            var isWinner = true;
            var stek = new Stack<char>();

            var rowLenght = playBoard.GetLength(1);
            var columnLenght = playBoard.GetLength(0);
            for (int j = 0; j < rowLenght; j++)
            {
                for (int i = 0; i < columnLenght; i++)
                {
                    if (playBoard[i, j] == '0')
                    {
                        continue;
                    }

                    isWinner = false;
                    stek.Push(playBoard[i, j]);
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

        /// <summary>
        /// Check if current player is skilled.
        /// </summary>
        /// <param name="chart">Chart with top skilled players.</param>
        /// <param name="points">Points of current player.</param>
        /// <returns>If player is added to the chart.</returns>
        public bool SignIfSkilled(string[,] chart, int points)
        {
            for (int i = 0; i < 5; i++)
            {
                if (chart[i, 0] != null)
                {
                    continue;
                }

                this.ProcessUserSigning(chart, points, i);
                return true;
            }

            int worstMoves = 0;
            int worstMovesChartPosition = 0;

            for (int i = 0; i < 5; i++)
            {
                if (int.Parse(chart[i, 0]) <= worstMoves)
                {
                    continue;
                }
                
                worstMovesChartPosition = i;
                worstMoves = int.Parse(chart[i, 0]);
            }

            if (points >= worstMoves)
            {
                return false;
            }

            this.ProcessUserSigning(chart, points, worstMovesChartPosition);
            return true;
        }

        /// <summary>
        /// Sign a user to the cart of top players.
        /// </summary>
        /// <param name="chart">Chart of top players.</param>
        /// <param name="points">Player points.</param>
        /// <param name="position">Chart position.</param>
        public void ProcessUserSigning(string[,] chart, int points, int position)
        {
            Console.WriteLine("Type in your name.");
            var tempUserName = Console.ReadLine();
            chart[position, 0] = points.ToString();
            chart[position, 1] = tempUserName;
        }
    }
}
