namespace BalloonsPopGame.Srs.Boards
{
    using System;
    using BaloonsCharacter;

    public class Board
    {
        private const byte MinRandomNumber = 1;
        private const byte MaxRandomNumber = 5;
        private readonly byte _rows;
        private readonly byte _columns;
        private readonly BaloonFactory _baloonFactory;

        // Flyweight
        public Board(byte rows, byte columns)
        {
            this._rows = rows;
            this._columns = columns;
            this._baloonFactory = new BaloonFactory();
        }

        public char[,] GenerateBoard()
        {
            var board = new char[this._rows, this._columns];
            var randomNumber = new Random();
            for (byte row = 0; row < this._rows; row++)
            {
                for (byte column = 0; column < this._columns; column++)
                {
                    byte currentNumber = (byte)randomNumber.Next(MinRandomNumber, MaxRandomNumber);
                    board[row, column] = this._baloonFactory.GetCharacter(currentNumber).Symbol;
                }
            }

            return board;
        }
    }
}
