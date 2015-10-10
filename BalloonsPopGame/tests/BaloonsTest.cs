namespace tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BalloonsPopGame.Srs.BaloonsCharacter;

    [TestClass]
    public class BaloonsTest
    {
        [TestMethod]
        public void TestBaloonA()
        {
            Baloon baloon = new BaloonA();
            Assert.AreEqual(baloon.Symbol, 'A');
        }

        [TestMethod]
        public void TestBaloonB()
        {
            Baloon baloon = new BaloonB();
            Assert.AreEqual(baloon.Symbol, 'B');
        }

        [TestMethod]
        public void TestBaloonC()
        {
            Baloon baloon = new BaloonC();
            Assert.AreEqual(baloon.Symbol, 'C');
        }

        [TestMethod]
        public void TestBaloonD()
        {
            Baloon baloon = new BaloonD();
            Assert.AreEqual(baloon.Symbol, 'D');
        }
    }
}
