namespace tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BalloonsPopGame.Srs;
    using BalloonsPopGame.Srs.Validators;

    [TestClass]
    public class GameEngineTest
    {
        [TestMethod]
        public void TestIfValidatorReturnsFalseIfInvalidCommand()
        {
            var engine = new GameEngine();
            var validator = new InputCommandValidator();
            var invalidCommands = new string[] { "1", "12", "1234", "-1 5", "0 10", "2 -10", "1/4" };
            foreach (var invalidCommand in invalidCommands)
            {
                Assert.IsFalse(validator.IsValidInputCommand(invalidCommand));
            }
        }

        [TestMethod]
        public void TestIfValidatorReturnsTrueIfValidCommand()
        {
            var engine = new GameEngine();
            var validator = new InputCommandValidator();
            var validCommands = new string[] { "0 9", "1 2", "1,2", "1.5", "9 0" };
            foreach (string validCommand in validCommands)
            {
                Assert.IsTrue(validator.IsValidInputCommand(validCommand));
            }
        }
    }
}
