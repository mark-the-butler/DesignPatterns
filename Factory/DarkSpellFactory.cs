namespace DesignPatterns.Factory
{
    public class DarkSpellFactory : ISpellFactory
    {
        public ISpell GenerateSpell()
        {
            return new Poison(40);
        }
    }
}