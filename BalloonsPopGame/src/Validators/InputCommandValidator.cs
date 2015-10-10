namespace BalloonsPopGame.Srs.Validators
{
    public class InputCommandValidator
    {
        public bool IsValidInputCommand(string currentCommand)
        {
            bool isValidLenght = currentCommand.Length == 3;
            if (!isValidLenght) return false;
            bool isValidSeparator = currentCommand[1] == ' ' || currentCommand[1] == '.' || currentCommand[1] == ',';

            bool isValidColumnNumber = currentCommand[0] >= '0' && currentCommand[0] <= '9';
            bool isValidRowNumber = currentCommand[2] >= '0' && currentCommand[2] <= '9';
            
            return isValidColumnNumber && isValidRowNumber && isValidSeparator;
        }
    }
}
