namespace BalloonsPopGame.Srs.Boards
{
    using System;
    using BaloonsCharacter;

    /// <summary>
    /// Creates a board.
    /// </summary>
    public class Board
    {
        private const byte MinRandomNumber = 1;
        private const byte MaxRandomNumber = 5;
        private readonly byte rows;
        private readonly byte columns;
        private readonly BalloonFactory balloonFactory;

        // Flyweight
        public Board(byte rows, byte columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.balloonFactory = new BalloonFactory();
        }

        public char[,] GenerateBoard()
        {
            var board = new char[this.rows, this.columns];
            var randomNumber = new Random();
            for (byte row = 0; row < this.rows; row++)
            {
                for (byte column = 0; column < this.columns; column++)
                {
                    byte currentNumber = (byte)randomNumber.Next(MinRandomNumber, MaxRandomNumber);
                    board[row, column] = this.balloonFactory.GetCharacter(currentNumber).Symbol;
                }
            }

            return board;
        }
    }
}
