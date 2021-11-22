using System;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
        }
    }
}
