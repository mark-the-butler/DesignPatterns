using System;

namespace DesignPatterns.Template
{
    public abstract class Character
    {
        protected virtual void Move()
        {
            Console.WriteLine("Moved 5 feet!");   
        }
        protected abstract void Attack();

        public void Execute()
        {
            Move();
            Attack();
        }
    }
}
