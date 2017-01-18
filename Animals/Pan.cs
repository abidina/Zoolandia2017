using System;

namespace Zoolandia.Animals
{
    public class Pan : Animal
    {
        public virtual void walk()
        {
            Console.WriteLine("It can walk.");
        }       
    }
}