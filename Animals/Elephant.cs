using System;

namespace Zoolandia.Animals
{
    public class Elephant : Animal
    {
        public int Height { get; set; }

        public override void sleep()
        {
            Console.WriteLine("The elephant sleeps standing up!");
        }
    }
}