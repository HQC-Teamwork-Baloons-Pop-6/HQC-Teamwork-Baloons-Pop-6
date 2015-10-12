namespace BalloonsPopGame.Srs.Boards
{
    using System;
    using BaloonsCharacter;

    /// <summary>
    /// Creates a board.
    /// </summary>
    public class Board
    {
        /// <summary>
        /// Minimum random number.
        /// </summary>
        private const byte MinRandomNumber = 1;

        /// <summary>
        /// Maximum random number.
        /// </summary>
        private const byte MaxRandomNumber = 5;
        
        /// <summary>
        /// Value of rows.
        /// </summary>
        private readonly byte rows;

        /// <summary>
        /// Value of columns.
        /// </summary>
        private readonly byte columns;

        /// <summary>
        /// Balloon factory instance.
        /// </summary>
        private readonly BalloonFactory balloonFactory;

        // Flyweight

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="rows">Count of board rows.</param>
        /// <param name="columns">Count of board columns.</param>
        public Board(byte rows, byte columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.balloonFactory = new BalloonFactory();
        }

        /// <summary>
        /// Generates board.
        /// </summary>
        /// <returns>Return the generated board.</returns>
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
