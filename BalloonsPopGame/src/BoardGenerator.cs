namespace BalloonsPopGame.Srs
{
    using System;

    public abstract class BoardGenerator
    {
        private const byte MinRandomNumber = 1;
        private const byte MaxRandomNumber = 5;

        public static byte[,] GenerateBoard(byte rows, byte columns)
        {
            byte[,] board = new byte[rows, columns];
            Random randomNumber = new Random();
            for (byte row = 0; row < rows; row++)
            {
                for (byte column = 0; column < columns; column++)
                {
                    byte currentNumber = (byte)randomNumber.Next(MinRandomNumber, MaxRandomNumber);
                    board[row, column] = currentNumber;
                }
            }

            return board;
        }
    }
}
