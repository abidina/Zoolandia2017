using System;
using Zoolandia.Animals;

namespace Zoolandia{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Tiger Tony = new Tiger();
            Console.WriteLine(Tony.name);
            Wolf GrayWolf = new Wolf();
            GrayWolf.name = "Gray Wolf";
            Console.WriteLine(GrayWolf.name);
            GrayWolf.sleep();
            Elephant Ellie = new Elephant();
            Console.WriteLine(Ellie.name);
            Ellie.Height = 9;
            Parrot Iago = new Parrot();
            Iago.Color = "blue & gold";
            Iago.name = "Iago";
            Console.WriteLine(Iago.name);

            Console.WriteLine("I have a tiger who goes " + Tony.Roar() + " " + GrayWolf.name + " likes to howl: " + GrayWolf.Howl() + " My elephant is " + Ellie.Height + " feet tall. " + Iago.name + " the parrot is " + Iago.Color + ".");
        }
    }
}