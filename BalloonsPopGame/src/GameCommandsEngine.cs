namespace BalloonsPopGame.Srs
{
    using System;
    using Boards;
    using Command;
    using Formatters;
    using Printers;
    using ScoreBoardLogger;
    using Validators;

    ////TODO: Remove magic values!!
    
    /// <summary>
    /// Creates a game command engine.
    /// </summary>
    public class GameCommandsEngine
    {
        private readonly string currentCommand;
        private readonly string[,] topFive;

        public GameCommandsEngine(string currentCommand, string[,] topFive)
        {
            this.currentCommand = currentCommand;
            this.topFive = topFive;
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

            switch (this.currentCommand)
            {
                case "RESTART":
                    IInputCommand restart = new RestartCommand(boardGenerator, printer);
                    restart.Execute(ref playBoard, ref userMoves);
                    break;

                case "TOP":
                    IInputCommand topscoreBoard = new TopCommand(scoreBoard, this.topFive);
                    topscoreBoard.Execute(ref playBoard, ref userMoves);
                    break;

                case "EXIT":
                    break;

                default:
                    InputCommandValidator validator = new InputCommandValidator();
                    if (validator.IsValidInputCommand(this.currentCommand))
                    {
                        IInputCommand play = new PlayCommand(this.currentCommand, this.topFive, scoreBoard, boardGenerator, printer);
                        play.Execute(ref playBoard, ref userMoves);
                        break;
                    }

                    Console.WriteLine("Wrong input ! Try Again ! ");
                    break;
            }
        }
    }
}
