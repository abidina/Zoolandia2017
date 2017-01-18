using System;
using Zoolandia.Animals;

namespace Zoolandia{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Panthera Tony = new Panthera();
            Console.WriteLine(Tony.name);
            Canis GrayWolf = new Canis();
            GrayWolf.name = "Shaggydog";
            Console.WriteLine(GrayWolf.name);
            GrayWolf.sleep();
            Elephas Ellie = new Elephas("Ellie");
            Elephas Effie = new Elephas(10);
            Console.WriteLine(Ellie.name);
            Ellie.Height = 9;
            Psittacoidea Iago = new Psittacoidea("Polly want a cracker? ", 3);
            Iago.Color = "blue & gold";
            Iago.name = "Iago";
            Console.WriteLine(Iago.name);
            Console.WriteLine(Iago.Speak);

            Console.WriteLine("I have a tiger who goes " + Tony.Roar() + " " + GrayWolf.name + " likes to howl: " + GrayWolf.Howl() + " My elephant " + Ellie.name  + " is " + Ellie.Height + " feet tall. Her sister Effie is " + Effie.Height + " feet tall. "  + Iago.name + " the parrot is " + Iago.Color + ".");
        }
    }
}