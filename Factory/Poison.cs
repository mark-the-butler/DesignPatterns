using System;

namespace DesignPatterns.Factory
{
    public class Poison : ISpell
    {
        public int DamageFactor { get; }

        public Poison(int factor)
        {
            DamageFactor = factor;
        }

        public void Cast()
        {
            Console.WriteLine($"Damaged for {DamageFactor}");
        }
    }
}