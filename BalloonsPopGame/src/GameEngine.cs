namespace BalloonsPopGame.Srs
{
    using System;
    using System.Collections.Generic;
    using BalloonsPopGame.Srs.Boards;
    using BalloonsPopGame.Srs.Formatters;
    using BalloonsPopGame.Srs.ScoreBoardLogger;
    using BalloonsPopGame.Srs.BoardsManufacturers;
    using BalloonsPopGame.Srs.Validators;
    using BalloonsPopGame.Srs.Command;

    public class GameEngine
    {
        private const byte ScoreBoardRows = 5;
        private const byte ScoreBoardCols = 2;
        private const byte PlayBoardRows = 5;
        private const byte PlayBoardCols = 10;

        public void Start()
        {
            // Factory Method
            // Manufacturer manufacturer = new TelerikSoft();
            // char[,] playBoard = manufacturer.GenerateBoard();
            Board board = new Board(PlayBoardRows, PlayBoardCols);
            char[,] playBoard = board.GenerateBoard();

            // Singleton
            var printer = PrintingManager.Instance;
            printer.PrintPlayBoard(playBoard);

            // TODO topfive => List<Players>
            string[,] topFivePlayers = new string[ScoreBoardRows, ScoreBoardCols];
            string currentCommand = null;
            int userMoves = 0;
            while (currentCommand != "EXIT")
            {
                Console.WriteLine("Enter a row and column: ");
                currentCommand = Console.ReadLine();
                currentCommand = currentCommand.ToUpper().Trim();

                this.ProcessGame(currentCommand, topFivePlayers, ref playBoard, ref userMoves);
            }
        }

        // TODO topfive => List<Players>
        private void ProcessGame(string currentCommand, string[,] topFive, ref char[,] playBoard, ref int userMoves)
        {
            byte rowLenght = (byte)playBoard.GetLength(0);
            byte columnLenght = (byte)playBoard.GetLength(1);
            Board board = new Board(rowLenght, columnLenght);

            ScoreBoardFormatter formatter = new ScoreBoardFormatter();

            // FileLogger fileLogger = new FileLogger("scorebord.txt", formatter);
            ConsoleLogger consoleLogger = new ConsoleLogger(formatter);
            ScoreBoard scoreBoard = new ScoreBoard(consoleLogger);

            var printer = PrintingManager.Instance;

            switch (currentCommand)
            {
                case "RESTART":
                    IInputCommand restart = new RestartCommand(playBoard, board, printer);
                    restart.Execute();
                    userMoves = 0;
                    break;

                case "TOP":
                    IInputCommand topscoreBoard = new TopCommand(scoreBoard, topFive);
                    topscoreBoard.Execute();
                    break;

                case "EXIT":
                    break;

                default:
                    InputCommandValidator validator = new InputCommandValidator();
                    if (validator.IsValidInputCommand(currentCommand))
                    {
                        //IInputCommand play = new PlayCommand(currentCommand, userMoves, playBoard, topFive, scoreBoard, board, printer);
                        //play.Execute();
                        int userRow = int.Parse(currentCommand[0].ToString());
                        if (userRow > rowLenght - 1)
                        {
                            Console.WriteLine("Wrong input ! Try Again ! ");
                            return;
                        }

                        int userColumn = int.Parse(currentCommand[2].ToString());
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
                                scoreBoard.PrintTopFive(topFive);
                            }
                            else
                            {
                                Console.WriteLine("I am sorry you are not skillful enough for TopFive chart!");
                            }

                            playBoard = board.GenerateBoard();
                            userMoves = 0;
                        }

                        printer.PrintPlayBoard(playBoard);
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
