namespace BalloonsPopGame.Srs.Printers
{
    using System;
    using System.Text;

    /// <summary>
    /// Initialize a printing manager.
    /// </summary>
    public sealed class PrintingManager : IPrinterManager
    {
        /// <summary>
        /// Instance of the printing manager.
        /// </summary>
        private static PrintingManager printingManagerInstance;

        /// <summary>
        /// Prevents a default instance of the <see cref="PrintingManager"/> class from being created.
        /// </summary>
        private PrintingManager()
        {
        }

        /// <summary>
        /// Gets instance of printing manager.
        /// </summary>
        /// <value>Gets the value of the printing manager instance.</value>
        public static PrintingManager Instance
        {
            get { return printingManagerInstance ?? (printingManagerInstance = new PrintingManager()); }
        }

        /// <summary>
        /// Prints the play board.
        /// </summary>
        /// <param name="playBoard">Current play board value.</param>
        public void PrintPlayBoard(char[,] playBoard)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    ");
            for (byte column = 0; column < playBoard.GetLongLength(1); column++)
            {
                Console.Write(column + " ");
            }

            Console.WriteLine();

            int lineLenght = (int)(playBoard.GetLongLength(1) * 2) + 1;
            PrintLine(lineLenght);

            for (byte i = 0; i < playBoard.GetLongLength(0); i++)
            {
                Console.Write(i + " | ");
                for (byte j = 0; j < playBoard.GetLongLength(1); j++)
                {
                    if (playBoard[i, j] == '0')
                    {
                        Console.Write("  ");
                        continue;
                    }

                    Console.ForegroundColor = (ConsoleColor)(playBoard[i, j] % 16);
                    Console.Write(playBoard[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // TODO get color from baloon.color
                }

                Console.Write("| ");
                Console.WriteLine();
            }

            PrintLine(lineLenght);
        }
        
        /// <summary>
        /// Prints a line of the play board.
        /// </summary>
        /// <param name="count">Length of the line.</param>
        private static void PrintLine(int count)
        {
            var line = new StringBuilder();
            line.Append("   ");
            
            line.Append(new string('-', count));

            Console.WriteLine(line.ToString());
        }
    }
}