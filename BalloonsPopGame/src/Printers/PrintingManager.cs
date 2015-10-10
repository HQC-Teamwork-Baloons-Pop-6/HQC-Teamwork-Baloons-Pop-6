namespace BalloonsPopGame.Srs.Printers
{
    using System;
    using System.Text;

    public sealed class PrintingManager : IPrinterManager
    {
        private static PrintingManager printingManagerInstance;

        private PrintingManager()
        {
        }

        public static PrintingManager Instance
        {
            get { return printingManagerInstance ?? (printingManagerInstance = new PrintingManager()); }
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

                    // TODO get color from baloon.color
                }

                Console.Write("| ");
                Console.WriteLine();
            }

            PrintLine(playBoard);
        }

        private static void PrintLine(char[,] matrix)
        {
            var line = new StringBuilder();
            line.Append("   ");

            var countOfSymbols = (int)(matrix.GetLongLength(1) * 2) + 1;
            line.Append(new string('-', countOfSymbols));

            Console.WriteLine(line.ToString());
        }
    }
}