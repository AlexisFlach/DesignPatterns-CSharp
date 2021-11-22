using System;

namespace SimpleFactory
{
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing the pizza");
        }
        public override void Bake()
        {
            Console.WriteLine("Baking the pizza");
        }
        public override void Cut()
        {
            Console.WriteLine("Cuting the pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing the pizza");
        }
    }
}