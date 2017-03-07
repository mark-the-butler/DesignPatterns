using System;

namespace DesignPatterns.Singleton
{
    public class Game
    {
        private static Game _instance;
        private static readonly Object _lock = new Object();

        public static Game instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Game();
                        }
                    }
                }

                return _instance ;
            }
        }

        public Game()
        {
            Console.WriteLine("Building new instance!");
        }

        public void Execute()
        {
            Console.WriteLine("Executed the game!");
        }
    }
}
