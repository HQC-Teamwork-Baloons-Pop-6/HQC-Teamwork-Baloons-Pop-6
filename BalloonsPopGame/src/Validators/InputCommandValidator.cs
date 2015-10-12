// <copyright file="InputCommandValidator.cs" company="Balloon-Pop-6">
// 
//      Copyright (c) Balloon-Pop-6. All rights reserved.
// 
// </copyright>
// <summary>This is the Balloon pop 6 class.</summary>
namespace BalloonsPopGame.Srs.Validators
{
    /// <summary>
    /// Validates input commands.
    /// </summary>
    public class InputCommandValidator
    {
        /// <summary>
        /// Check if given command is valid.
        /// </summary>
        /// <param name="currentCommand">Command for checking.</param>
        /// <returns>If command is valid.</returns>
        public bool IsValidInputCommand(string currentCommand)
        {
            bool isValidLenght = currentCommand.Length == 3;
            if (!isValidLenght)
            {
                return false;
            }

            bool isValidSeparator = currentCommand[1] == ' ' || currentCommand[1] == '.' || currentCommand[1] == ',';

            bool isValidColumnNumber = currentCommand[0] >= '0' && currentCommand[0] <= '9';
            bool isValidRowNumber = currentCommand[2] >= '0' && currentCommand[2] <= '9';
            
            return isValidColumnNumber && isValidRowNumber && isValidSeparator;
        }
    }
}
