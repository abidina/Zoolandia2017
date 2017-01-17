using System;

namespace Zoolandia.Animals
{
    public class Tiger : Animal
    {
        //public string name { get; set; }
        
        public string Roar()
        {
            return "ROAR!!";
        }

        public override void sleep() 
        {
            Console.WriteLine("The tiger dreams about eating people.");
        }
    }
}