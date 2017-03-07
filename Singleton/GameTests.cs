using Microsoft.Practices.Unity;
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

        [Test]
        public void Game_Should_Return_Same_Instance_Using_Unity_Container()
        {
            var container = new UnityContainer();

            container.RegisterType<Game>(new ContainerControlledLifetimeManager());

            var instancce1 = container.Resolve<Game>();
            var instance2 = container.Resolve<Game>();

            Assert.That(instancce1, Is.EqualTo(instance2));
        }
    }
}
