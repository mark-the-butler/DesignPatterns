using System.Collections.Generic;
using NUnit.Framework;

namespace DesignPatterns.Adapter
{
    [TestFixture]
    public class TroopsTests
    {
        [Test]
        public void StartWar_Moves_And_Attacks()
        {
            var farmer = new Farmer();

            var troops = new List<IFighter>
            {
                new Barbarian(),
                new FightingFarmer(farmer)
            };

            var warTroops = new Troops(troops);

            warTroops.StartWar();
        }
    }
}
