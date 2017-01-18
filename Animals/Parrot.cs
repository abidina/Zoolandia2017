using System;

namespace Zoolandia.Animals
{
    public class Parrot : Animal
    {
        public string Color { get; set; }

        public override void sleep() 
        {
            Console.WriteLine("The parrot sings in his sleep!");
        }
    }
}