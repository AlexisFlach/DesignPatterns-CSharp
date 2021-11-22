using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new();
            PizzaStore store = new(factory);
            store.OrderPizza("cheese");
        }
    }
}
