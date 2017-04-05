namespace DesignPatterns.Factory
{
    public class SpellFactory : ISpellFactory
    {
        public ISpell GenerateSpell()
        {
            return new Heal(60);
        }
    }
}