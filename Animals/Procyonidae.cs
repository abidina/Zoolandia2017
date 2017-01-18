using System;

namespace Zoolandia.Animals
{
    public class Procyonidae : Animal
    {
        public override string Eat(int numberOfFoods)
        {
            string animalEat = base.Eat(2);
            return animalEat + "Nom nom nom";
        }
        
    }
}