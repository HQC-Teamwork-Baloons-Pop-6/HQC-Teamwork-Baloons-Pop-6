namespace BalloonsPopGame.Srs
{
    using System;
    using BalloonsPopGame.Srs.Products;

    public class GameEngine
    {
        public void Start(string[,] topFive, byte[,] playBoard)
        {
            string currentCommand = null;
            int userMoves = 0;

            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                currentCommand = currentCommand.ToUpper().Trim();

                ProcessGame(currentCommand, topFive, ref playBoard, ref userMoves);
            }
        }

        private static void ProcessGame(string currentCommand, string[,] topFive, ref byte[,] playBoard, ref int userMoves)
        {
            byte rowLenght = (byte)playBoard.GetLength(0);
            byte columnLenght = (byte)playBoard.GetLength(1);
            Board board = new Board(rowLenght, columnLenght);
            var log = PrintingManager.Instance;

            switch (currentCommand)
            {
                case "RESTART":
                    playBoard = board.GenerateBoard();
                    log.PrintMatrix(playBoard);
                    userMoves = 0;
                    break;

                case "TOP":
                    ScoreBoard.PrintTopFive(topFive);
                    break;

                case "EXIT":
                    break;

                default:
                    if ((currentCommand.Length == 3) && (currentCommand[0] >= '0' && currentCommand[0] <= '9') && (currentCommand[2] >= '0' && currentCommand[2] <= '9') && (currentCommand[1] == ' ' || currentCommand[1] == '.' || currentCommand[1] == ','))
                    {
                        int userRow, userColumn;
                        userRow = int.Parse(currentCommand[0].ToString());
                        if (userRow > rowLenght - 1)
                        {
                            Console.WriteLine("Wrong input ! Try Again ! ");
                            return;
                        }

                        userColumn = int.Parse(currentCommand[2].ToString());

                        if (GameLogic.CheckIfEmptyElseChangeCurrentPlayBoard(playBoard, userRow, userColumn))
                        {
                            Console.WriteLine("cannot pop missing ballon!");
                            return;
                        }

                        userMoves++;
                        if (Winner.CheckIfIsWinner(playBoard))
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

                            playBoard = board.GenerateBoard();
                            userMoves = 0;
                        }

                        log.PrintMatrix(playBoard);
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
