namespace DesignPatterns.Command
{
    public class MoveCommand : ICommand
    {
        private readonly IFighter _fighter;
        private readonly int _xSteps;
        private readonly int _ySteps;

        public MoveCommand(IFighter fighter, int xSteps, int ySteps)
        {
            _fighter = fighter;
            _xSteps = xSteps;
            _ySteps = ySteps;
        }

        public void Execute()
        {
            _fighter.Move(_xSteps, _ySteps);
        }

        public void Undo()
        {
            _fighter.Move(_xSteps * -1, _ySteps * -1);
        }
    }
}