using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template
{
    public class Troop
    {
        private IEnumerable<Character> _troops;

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
