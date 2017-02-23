using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatterns.Composite
{
    [TestFixture]
    public class BarbarianTests
    {
        [Test]
        public void Barbian_Obeys_The_Commands()
        {
            var barbarian = new Barbarian();

            barbarian.Add(new Attack());
            barbarian.Add(new Move());
            barbarian.Add(new Attack());
            barbarian.Add(new RageCommand(new List<ICommand> {new Attack(), new Attack(), new Attack(), new Move()}));

            barbarian.ExecuteCommands();
        }
    }
}
