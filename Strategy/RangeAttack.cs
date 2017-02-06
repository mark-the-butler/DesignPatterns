namespace DesignPatterns.Strategy
{
    public class RangeAttack : IFightingStrategy
    {
        public string Attack()
        {
            return "Attacked with Range";
        }
    }
}