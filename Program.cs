using System;
using Zoolandia.Animals;

namespace Zoolandia{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Tiger Tony = new Tiger();
            Console.WriteLine(Tony.Roar());
        }
    }
}