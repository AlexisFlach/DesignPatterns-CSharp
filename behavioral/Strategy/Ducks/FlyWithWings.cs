using System;

namespace Strategy.Ducks
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly() {
            Console.WriteLine("I am flyyyiiiing");
        }
    }
}