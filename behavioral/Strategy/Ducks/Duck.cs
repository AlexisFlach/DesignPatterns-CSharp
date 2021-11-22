using System;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        public Duck() { }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public virtual void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim Swim!!");
        }
        public abstract void Display();
    }
}