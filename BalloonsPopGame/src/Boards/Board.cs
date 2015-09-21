namespace BalloonsPopGame.Srs.Boards
{
    using System;
    using BalloonsPopGame.Srs.BaloonsCharacter;

    public class Board
    {
        private const byte MinRandomNumber = 1;
        private const byte MaxRandomNumber = 5;
        private byte rows;
        private byte columns;
        private BaloonFactory baloonFactory;

        // Flyweight
        public Board(byte rows, byte columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.baloonFactory = new BaloonFactory();
        }

        public char[,] GenerateBoard()
        {
            char[,] board = new char[this.rows, this.columns];
            Random randomNumber = new Random();
            for (byte row = 0; row < this.rows; row++)
            {
                for (byte column = 0; column < this.columns; column++)
                {
                    byte currentNumber = (byte)randomNumber.Next(MinRandomNumber, MaxRandomNumber);
                    board[row, column] = this.baloonFactory.GetCharacter(currentNumber).Symbol;
                }
            }

            return board;
        }
    }
}
