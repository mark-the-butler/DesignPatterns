using System;

namespace DesignPatterns.Template
{
    public class Archer : Character
    {
        protected override void Attack()
        {
            Console.WriteLine("Archer Attacked!");
        }

        protected override void Move()
        {
            Console.WriteLine("Moved 2 feet!");
        }
    }
}