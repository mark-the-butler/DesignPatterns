using NUnit.Framework;

namespace DesignPatterns.Singleton
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Game_Should_Always_Return_Same_Instance()
        {
            var instance1 = Game.instance;
            var instance2 = Game.instance;

            Assert.That(instance1, Is.EqualTo(instance2));
        }
    }
}
