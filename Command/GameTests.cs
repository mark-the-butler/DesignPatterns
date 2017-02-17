using NUnit.Framework;

namespace DesignPatterns.Command
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void StartWar_Gets_Things_GOING()
        {
            var bob = new Barbarian("Bob");
            var jim = new Barbarian("Jim");
            var game = new Game();

            game.AddCommand(new MoveCommand(bob,1,2));
            game.AddCommand(new MoveCommand(jim,1,2));
            game.AddCommand(new AttackCommand(bob));
            game.AddCommand(new AttackCommand(jim));
            game.AddCommand(new AttackCommand(jim));
            game.AddCommand(new MoveCommand(bob,3,2));
            game.AddCommand(new MoveCommand(bob,1,6));
            game.AddCommand(new AttackCommand(jim));
            game.AddCommand(new MoveCommand(jim,8,6));
            game.AddCommand(new MoveCommand(jim,6,2));

            game.StartWar();
            game.Rewind();
        }
    }
}
