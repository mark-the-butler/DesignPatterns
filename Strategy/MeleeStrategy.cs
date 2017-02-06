using System;

namespace DesignPatterns.Strategy
{
    public class MeleeStrategy : IFightingStrategy
    {
        public string Attack()
        {
            return "Attacked with Melee";
        }
    }
}
