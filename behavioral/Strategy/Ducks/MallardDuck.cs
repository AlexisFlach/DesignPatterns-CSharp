using System;

namespace Strategy.Ducks
{
    public class MallardDuck : Duck
    {       
        public MallardDuck(){
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quacker();
        }
            public override void Display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}