using System;

namespace Zoolandia.Animals
{
    public class Elephas : Animal
    {
        public int Height { get; set; }

        public Elephas(string name)
        {
            this.name = name;
        }

        public Elephas(int height)
        {
            this.Height = height;
        }

        public override void sleep()
        {
            Console.WriteLine("The elephant sleeps standing up!");
        }
    }
}