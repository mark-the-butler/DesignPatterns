using Microsoft.Practices.Unity;

namespace DesignPatterns.Factory
{
    public class DadaBase
    {
        public void Execute(string spellType)
        {
            var factory = GetFactory(spellType);
            var spell = factory.GenerateSpell();
            spell.Cast();
        }

        private ISpellFactory GetFactory(string spellType)
        {
            var container = CreateContainer();

            return container.Resolve<ISpellFactory>(spellType);
        }

        private UnityContainer CreateContainer()
        {
           var unityContainer = new UnityContainer();
           unityContainer.RegisterType<ISpellFactory, SpellFactory>("Heal");
           unityContainer.RegisterType<ISpellFactory, DarkSpellFactory>("Poison");

           return unityContainer;
        }
    }
}
