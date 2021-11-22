using System;

namespace Strategy.Ducks
{
    public class Quacker : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!!");
        }
    }
}