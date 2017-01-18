using System;

namespace Zoolandia.Animals
{
    public class Troglodytes : Pan
    {
        string commonName = "Chimpanzee";
        string scientificName = "Pan Trogdolyte";

        public override string Eat(int numberOfFoods) 
        {
            string chimpEat = base.Eat(1);
            return chimpEat;
        }

        public override void walk()
        {
            Console.WriteLine("Chimp loves to walk around.");
        }    
    }
}