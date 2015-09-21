namespace BalloonsPopGame.Srs
{
    using System;
    using System.Text;

    public sealed class PrintingManager
    {
        private static PrintingManager printingManagerInstance;

        private PrintingManager()
        {
        }

        public static PrintingManager Instance
        {
            get
            {
                if (printingManagerInstance == null)
                {
                    printingManagerInstance = new PrintingManager();
                }

                return printingManagerInstance;
            }
        }

        public void PrintPlayBoard(char[,] playBoard)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    ");
            for (byte column = 0; column < playBoard.GetLongLength(1); column++)
            {
                Console.Write(column + " ");
            }

            Console.WriteLine();

            PrintLine(playBoard);

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
                }

                Console.Write("| ");
                Console.WriteLine();
            }

            PrintLine(playBoard);
        }

        private static void PrintLine(char[,] matrix)
        {
            StringBuilder line = new StringBuilder();
            line.Append("   ");
            for (byte column = 0; column < (matrix.GetLongLength(1) * 2) + 1; column++)
            {
                line.Append("-");
            }

            Console.WriteLine(line.ToString());
        }
    }
}