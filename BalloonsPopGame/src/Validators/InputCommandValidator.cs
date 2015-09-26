namespace BalloonsPopGame.Srs.Validators
{
    public class InputCommandValidator
    {
        public InputCommandValidator()
        {
        }

        public bool IsValidInputCommand(string currentCommand)
        {
            return (currentCommand.Length == 3) &&
                   (currentCommand[0] >= '0' && currentCommand[0] <= '9') &&
                   (currentCommand[2] >= '0' && currentCommand[2] <= '9') &&
                   (currentCommand[1] == ' ' || currentCommand[1] == '.' || currentCommand[1] == ',');
        }
    }
}
