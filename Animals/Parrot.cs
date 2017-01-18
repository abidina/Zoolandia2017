using System;

namespace Zoolandia.Animals
{
    public class Parrot : Animal
    {
        public string Color { get; set; }
        public string Speak { get; set; }
        public int NoOfSpeaks { get; set; }

        public Parrot(string speak, int noOfSpeaks)
        {
            this.Speak = speak;
            this.NoOfSpeaks = noOfSpeaks;
            
            for (var i = 0; i < this.NoOfSpeaks; i++)
            {
                this.Speak += speak;
            }

        }

        public override void sleep() 
        {
            Console.WriteLine("The parrot sings in his sleep!");
        }
    }
}