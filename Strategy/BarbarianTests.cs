using NUnit.Framework;

namespace DesignPatterns.Strategy
{
    [TestFixture]
    public class BarbarianTests
    {
        private Barbarian barbarian;

        [SetUp]
        public void Setup()
        {
            barbarian = new Barbarian(new MeleeStrategy());
        }

        [Test]
        public void PerformAttack_Can_Do_Attack()
        {
            var result = barbarian.PerformAttack();

            Assert.That(result, Is.EqualTo("Attacked with Melee"));
        }

        [Test]
        public void PerformAttack_Can_Change_Strategy()
        {
            barbarian.ChangeStrategy(new RangeAttack());

            var result = barbarian.PerformAttack();

            Assert.That(result, Is.EqualTo("Attacked with Range"));
        }
    }
}
