namespace tests
{
    using BalloonsPopGame.Srs.BaloonsCharacter;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class BaloonsTest
    {
        [TestMethod]
        public void TestBaloonA()
        {
            Balloon balloon = new BalloonA();
            Assert.AreEqual(balloon.Symbol, 'A');
        }

        [TestMethod]
        public void TestBaloonB()
        {
            Balloon balloon = new BalloonB();
            Assert.AreEqual(balloon.Symbol, 'B');
        }

        [TestMethod]
        public void TestBaloonC()
        {
            Balloon balloon = new BalloonC();
            Assert.AreEqual(balloon.Symbol, 'C');
        }

        [TestMethod]
        public void TestBaloonD()
        {
            Balloon balloon = new BalloonD();
            Assert.AreEqual(balloon.Symbol, 'D');
        }
    }
}
