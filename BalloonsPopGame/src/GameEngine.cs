namespace BalloonsPopGame.Srs
{
    using System;

    public class GameEngine
    {
        public void Start(string[,] topFive, byte[,] matrix)
        {
            string currentCommand = null;
            int userMoves = 0;

            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                currentCommand = currentCommand.ToUpper().Trim();

                ProcessGame(currentCommand, topFive, ref matrix, ref userMoves);
            }
        }
        private static void ProcessGame(string currentCommand, string[,] topFive, ref byte[,] matrix, ref int userMoves)
        {
            switch (currentCommand)
            {
                case "RESTART":
<<<<<<< HEAD
                    matrix = BoardGenerator.GenerateBoard(5, 10);
=======
                    matrix = MatrixGenerator.GenerateMatrix(5, 10);
>>>>>>> bb139ec5b1a454fc1f5c837eff99468cd46608bf
                    PrintingManager.PrintMatrix(matrix);
                    userMoves = 0;
                    break;

                case "TOP":
                    ScoreBoard.PrintTopFive(topFive);
                    break;

                default:
                    if ((currentCommand.Length == 3) && (currentCommand[0] >= '0' && currentCommand[0] <= '9') && (currentCommand[2] >= '0' && currentCommand[2] <= '9') && (currentCommand[1] == ' ' || currentCommand[1] == '.' || currentCommand[1] == ','))
                    {
                        int userRow, userColumn;
                        userRow = int.Parse(currentCommand[0].ToString());
                        if (userRow > 4)
                        {
                            Console.WriteLine("Wrong input ! Try Again ! ");
                            return;
                        }

                        userColumn = int.Parse(currentCommand[2].ToString());

                        if (GameLogic.CheckIfEmptyElseChangeCurrentPlayBoard(matrix, userRow, userColumn))
                        {
                            Console.WriteLine("cannot pop missing ballon!");
                            return;
                        }

                        userMoves++;
                        if (Winner.CheckIfIsWinner(matrix))
                        {
                            Console.WriteLine("Gratz ! You completed it in {0} moves.", userMoves);
                            if (Winner.SignIfSkilled(topFive, userMoves))
                            {
                                ScoreBoard.PrintTopFive(topFive);
                            }
                            else
                            {
                                Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                            }

<<<<<<< HEAD
                            matrix = BoardGenerator.GenerateBoard(5, 10);
=======
                            matrix = MatrixGenerator.GenerateMatrix(5, 10);
>>>>>>> bb139ec5b1a454fc1f5c837eff99468cd46608bf
                            userMoves = 0;
                        }

                        PrintingManager.PrintMatrix(matrix);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input ! Try Again ! ");
                        break;
                    }
            }
        }
    }
}
