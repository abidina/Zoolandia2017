using System;

namespace Zoolandia.Animals
{
    public class Troglodytes : Pan
    {
        public int NumberOfFoods { get; set; }
        string commonName = "Chimpanzee";
        string scientificName = "Pan Trogdolyte";

        public override string Eat(int numberOfFoods) 
        {
            this.NumberOfFoods = numberOfFoods;
            string chimpEat = base.Eat(numberOfFoods);
            return chimpEat;
        }

        public override void walk()
        {
            Console.WriteLine("Chimp loves to walk around.");
        }    
    }
}