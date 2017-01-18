using System;

namespace Zoolandia.Animals
{
    public class Canis : Animal
    {
        public string Howl()
        {
            return "A-oooooooooooooooo!";
        }

        public override void sleep()
        {
            base.sleep();
        }

        //public Wolf(Wolf.sleep())
        //{
        //    base.sleep();
        //}
    }
}