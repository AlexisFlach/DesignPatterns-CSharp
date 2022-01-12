namespace Cafe
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost() + .9;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}