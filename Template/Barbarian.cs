using System;

namespace DesignPatterns.Template
{
    public class Barbarian : Character
    {
        protected override void Attack()
        {
            Console.WriteLine("Barbarian Attacked!");
        }
    }
}