using NUnit.Framework;

namespace DesignPatterns.Strategy
{
    [TestFixture]
    public class BarbarianTests
    {
        [Test]
        public void PerformAttack_Can_Do_Attack()
        {
            var barbarian = new Barbarian(new MeleeStrategy());
            var result = barbarian.PerformAttack();

            Assert.That(result, Is.EqualTo("Attacked with Melee"));
        }

        [Test]
        public void PerformAttack_Can_Change_Strategy()
        {
            var barbarian = new Barbarian(new MeleeStrategy());
            barbarian.ChangeStrategy(new RangeAttack());

            var result = barbarian.PerformAttack();

            Assert.That(result, Is.EqualTo("Attacked with Range"));
        }
    }
}
