using System;

namespace DesignPatterns.Composite
{
    public class Attack : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Character has attacked!");
        }
    }
}