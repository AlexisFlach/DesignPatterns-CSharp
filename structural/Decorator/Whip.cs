namespace Decorator
{
    public class Whip : Beverage
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.6;
        }
    }
}