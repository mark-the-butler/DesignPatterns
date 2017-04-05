using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatterns.Factory
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Healing_Cast_Spell_Casts_Correct_Spell()
        {
            var dadaBase = new DadaBase();
            dadaBase.Execute("Heal");

        }

        [Test]
        public void Poison_Cast_Spell_Casts_Correct_Spell()
        {
            var dadaBase = new DadaBase();
            dadaBase.Execute("Poison");

        }
    }
}
