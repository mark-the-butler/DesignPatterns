using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public class Game
    {
        private List<ICommand> _commands;

        public Game()
        {
            _commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void StartWar()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Rewind()
        {
            for(int i = _commands.Count -1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}