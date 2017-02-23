using System;

namespace DesignPatterns.Composite
{
    public class Move : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Character has move!");
        }
    }
}