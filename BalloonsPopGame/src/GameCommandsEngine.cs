namespace BalloonsPopGame.Srs
{
    using System;
    using Boards;
    using Command;
    using Formatters;
    using ScoreBoardLogger;
    using Validators;

    //TODO: Remove magic values!!
    public class GameCommandsEngine
    {
        private readonly string _currentCommand;
        private readonly string[,] _topFive;

        public GameCommandsEngine(string currentCommand, string[,] topFive)
        {
            this._currentCommand = currentCommand;
            this._topFive = topFive;
        }

        public void ProcessGame(ref char[,] playBoard, ref int userMoves)
        {
            byte rowLenght = (byte)playBoard.GetLength(0);
            byte columnLenght = (byte)playBoard.GetLength(1);
            Board boardGenerator = new Board(rowLenght, columnLenght);

            ScoreBoardFormatter formatter = new ScoreBoardFormatter();

            // ILogger fileLogger = new FileLogger("scorebord.txt", formatter);
            ILogger consoleLogger = new ConsoleLogger(formatter);
            ScoreBoard scoreBoard = new ScoreBoard(consoleLogger);

            var printer = PrintingManager.Instance;

            switch (_currentCommand)
            {
                case "RESTART":
                    IInputCommand restart = new RestartCommand(boardGenerator, printer);
                    restart.Execute(ref playBoard, ref userMoves);
                    break;

                case "TOP":
                    IInputCommand topscoreBoard = new TopCommand(scoreBoard, _topFive);
                    topscoreBoard.Execute(ref playBoard, ref userMoves);
                    break;

                case "EXIT":
                    break;

                default:
                    InputCommandValidator validator = new InputCommandValidator();
                    if (validator.IsValidInputCommand(_currentCommand))
                    {
                        IInputCommand play = new PlayCommand(_currentCommand, _topFive, scoreBoard, boardGenerator, printer);
                        play.Execute(ref playBoard, ref userMoves);
                        break;
                    }
                    Console.WriteLine("Wrong input ! Try Again ! ");
                    break;
            }
        }
    }
}
