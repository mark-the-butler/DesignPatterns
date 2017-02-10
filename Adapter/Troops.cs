using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    public class Troops
    {
        private readonly IEnumerable<IFighter> _troops;

        public Troops(IEnumerable<IFighter> troops)
        {
            _troops = troops;
        }

        public void StartWar()
        {
            foreach (var troop in _troops)
            {
                troop.Move();
                troop.Attack();
            }
        }
    }
}
