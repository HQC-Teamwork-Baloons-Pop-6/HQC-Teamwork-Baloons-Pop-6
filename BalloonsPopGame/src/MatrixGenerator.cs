namespace BalloonsPopGame.Srs
{
    using System;

    public abstract class MatrixGenerator
    {
        private const byte MinRandomNumber = 1;
        private const byte MaxRandomNumber = 5;

        public static byte[,] GenerateMatrix(byte rows, byte columns)
        {
            byte[,] matrix = new byte[rows, columns];
            Random randomNumber = new Random();
            for (byte row = 0; row < rows; row++)
            {
                for (byte column = 0; column < columns; column++)
                {
                    byte currentNumber = (byte)randomNumber.Next(MinRandomNumber, MaxRandomNumber);
                    matrix[row, column] = currentNumber;
                }
            }

            return matrix;
        }
    }
}
