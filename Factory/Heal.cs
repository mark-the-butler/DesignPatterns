using System;

namespace DesignPatterns.Factory
{
    public class Heal : ISpell
    {
        public int HealFactor { get; }

        public Heal(int factor)
        {
            HealFactor = factor;
        }

        public void Cast()
        {
            Console.WriteLine($"Healed for {HealFactor}");
        }
    }
}