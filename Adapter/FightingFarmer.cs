using System;

namespace DesignPatterns.Adapter
{
    public class FightingFarmer : IFighter
    {
        private readonly Farmer _farmer;

        public FightingFarmer(Farmer farmer)
        {
            _farmer = farmer;
        }

        public void Attack()
        {
            Console.WriteLine("Farmer has attacked with a pitch fork!");
        }

        public void Move()
        {
            _farmer.Move();
        }
    }
}