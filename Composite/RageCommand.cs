using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class RageCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public RageCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}