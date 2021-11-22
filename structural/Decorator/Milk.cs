namespace Decorator
{
    public class Milk : Beverage
    {
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }
    }
}