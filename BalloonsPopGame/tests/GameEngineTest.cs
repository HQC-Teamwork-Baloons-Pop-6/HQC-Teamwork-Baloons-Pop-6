namespace tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BalloonsPopGame.Srs;

    [TestClass]
    public class GameEngineTest
    {
        [TestMethod]
        public void TestIfValidatorReturnsFalseIfInvalidCommand()
        {
            GameEngine engine = new GameEngine();
            var invalidCommands = new string[] { "1", "12", "1234", "-1 5", "0 10", "2 -10", "1/4" };
            for (int i = 0; i < invalidCommands.Length; i++)
            {
                Assert.IsFalse(engine.IsValidInputCommand(invalidCommands[i]));
            }
        }

        [TestMethod]
        public void TestIfValidatorReturnsTrueIfValidCommand()
        {
            GameEngine engine = new GameEngine();
            var invalidCommands = new string[] { "0 9", "1 2", "1,2", "1.5", "9 0" };
            for (int i = 0; i < invalidCommands.Length; i++)
            {
                Assert.IsTrue(engine.IsValidInputCommand(invalidCommands[i]));
            }
        }
    }
}
