namespace DesignPatterns.Strategy
{
    public class Barbarian
    {
        private IFightingStrategy _fightingStrategy;

        public Barbarian(IFightingStrategy fightingStrategy)
        {
            _fightingStrategy = fightingStrategy;
        }

        public string PerformAttack()
        {
            return _fightingStrategy.Attack();
        }

        public void ChangeStrategy(IFightingStrategy newStrategy)
        {
            _fightingStrategy = newStrategy;
        }
    }
}
