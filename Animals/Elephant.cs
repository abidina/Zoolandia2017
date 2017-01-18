using System;

namespace Zoolandia.Animals
{
    public class Elephant : Animal
    {
        public int Height { get; set; }

        public Elephant(string name)
        {
            this.name = name;
        }

        public Elephant(int height)
        {
            this.Height = height;
        }

        public override void sleep()
        {
            Console.WriteLine("The elephant sleeps standing up!");
        }
    }
}