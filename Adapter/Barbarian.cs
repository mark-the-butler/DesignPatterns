using System;

namespace DesignPatterns.Adapter
{
    public class Barbarian : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Barbarian has attacked!");
        }

        public void Move()
        {
            Console.WriteLine("Barbarian has moved 5 feet!");
        }
    }
}