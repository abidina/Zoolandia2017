using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }

        public virtual void sleep()
        {
            Console.WriteLine("The animal is now sleeping. Zzzzzz... ");
        }
        
    }
}