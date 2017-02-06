using System;

namespace DesignPatterns.Template
{
    // Abstract similar to Interface: You cannot instantiate it but you can add logic to its methods
    public abstract class Character
    {
        // Virtual means you can override the method but you don't have to, if you don't then it will use default implementation of the base method
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
