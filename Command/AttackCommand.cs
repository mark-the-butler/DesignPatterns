using System;

namespace DesignPatterns.Command
{
    public class AttackCommand : ICommand
    {
        private readonly IFighter _fighter;

        public AttackCommand(IFighter fighter)
        {
            _fighter = fighter;
        }

        public void Execute()
        {
            Console.WriteLine($"{_fighter.Name} attacked!" );
        }

        public void Undo()
        {
            Console.WriteLine("Cannot undo this command!");
        }
    }
}