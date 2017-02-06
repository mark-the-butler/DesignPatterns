using System.Collections.Generic;
using NUnit.Framework;

namespace DesignPatterns.Template
{
    [TestFixture]
    public class TroopTests
    {
        [Test]
        public void StartWar()
        {

            var troopMembers = new List<Character> {new Archer(), new Barbarian(), new Barbarian()};
            var troop = new Troop(troopMembers);

            troop.StartWar();
        }
    }
}
