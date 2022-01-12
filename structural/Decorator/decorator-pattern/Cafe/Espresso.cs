namespace Cafe
{
    public class Espresso : Beverage
    {
        public Espresso() => Description = "Espresso";
        public override double Cost() => 1.99;
    }
}