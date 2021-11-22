using System;
using Decorator;


namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso = new Milk(espresso);
            espresso = new Whip(espresso);
            Console.WriteLine(espresso.Cost());
            Console.WriteLine(espresso.GetDescription());
        }
    }
}
