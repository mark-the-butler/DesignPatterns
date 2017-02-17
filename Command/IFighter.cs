namespace DesignPatterns.Command
{
    public interface IFighter
    {
        string Name { get; }
        int PositionX { get; }
        int PositionY { get; }
        void Move(int stepsX, int stepsY);
    }
}