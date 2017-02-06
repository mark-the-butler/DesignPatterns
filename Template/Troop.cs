using System.Collections.Generic;

namespace DesignPatterns.Template
{
    public class Troop
    {
        private readonly IEnumerable<Character> _troops;

        public Troop(IEnumerable<Character> troops)
        {
            _troops = troops;
        }

        public void StartWar()
        {
            foreach (var troop in _troops)
            {
                troop.Execute();
            }
        }
    }
}
