using System;

namespace DesignPatterns.Command
{
    public class Barbarian : IFighter
    {
        public string Name { get; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Barbarian(string name)
        {
            Name = name;
            Move(100,100);
        }

        public void Move(int stepsX, int stepsY)
        {
            PositionX += stepsX;
            PositionY += stepsY;
            Console.WriteLine($"{Name} is at {PositionX}, {PositionY}");
        }
    }
}
