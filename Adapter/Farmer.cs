using System;

namespace DesignPatterns.Adapter
{
    public class Farmer
    {
        public void Move()
        {
            Console.WriteLine("Farmer has moved 7 feet!");
        }

        public void FeedAnimals()
        {
            Console.WriteLine("Feeding the cows!");
        }
    }
}