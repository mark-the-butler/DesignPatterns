using System;

namespace DesignPatterns.Template
{
    public class Barbarian : Character
    {
        // Override is how you change the default behavior of a virtual method
        protected override void Attack()
        {
            Console.WriteLine("Barbarian Attacked!");
        }
    }
}