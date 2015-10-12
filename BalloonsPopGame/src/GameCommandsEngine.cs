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
        /// <summary>
        /// Value of current command.
        /// </summary>
        private readonly string currentCommand;

        /// <summary>
        /// Top of players.
        /// </summary>
        private readonly string[,] topPlayers;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCommandsEngine"/> class.
        /// </summary>
        /// <param name="currentCommand">Given current command.</param>
        /// <param name="topPlayers">Given top players.</param>
        public GameCommandsEngine(string currentCommand, string[,] topPlayers)
        {
            this.currentCommand = currentCommand;
            this.topPlayers = topPlayers;
        }
        
        /// <summary>
        /// Process the game.
        /// </summary>
        /// <param name="playBoard">Current play board value.</param>
        /// <param name="playerMoves">Current player moves.</param>
        public void ProcessGame(ref char[,] playBoard, ref int playerMoves)
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
                    restart.Execute(ref playBoard, ref playerMoves);
                    break;

                case "TOP":
                    IInputCommand topscoreBoard = new TopCommand(scoreBoard, this.topPlayers);
                    topscoreBoard.Execute(ref playBoard, ref playerMoves);
                    break;

                case "EXIT":
                    break;

                default:
                    InputCommandValidator validator = new InputCommandValidator();
                    if (validator.IsValidInputCommand(this.currentCommand))
                    {
                        IInputCommand play = new PlayCommand(this.currentCommand, this.topPlayers, scoreBoard, boardGenerator, printer);
                        play.Execute(ref playBoard, ref playerMoves);
                        break;
                    }

                    Console.WriteLine("Wrong input ! Try Again ! ");
                    break;
            }
        }
    }
}
