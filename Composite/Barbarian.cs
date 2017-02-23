using System.Collections.Generic;
using System.Collections.Specialized;

namespace DesignPatterns.Composite
{
    public class Barbarian
    {
        private readonly List<ICommand> _commands;

        public Barbarian()
        {
            _commands = new List<ICommand>();
        }

        public void Add(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
