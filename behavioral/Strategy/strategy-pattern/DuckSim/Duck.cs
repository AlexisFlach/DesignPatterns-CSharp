namespace DuckSim
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;
        public Duck() { }
        public abstract string Display();

        public string PerformFly()
        {
            if (FlyBehavior == null) return "No flybehavior set";

            return FlyBehavior.Fly();
        }
        public string PerformQuack()
        {
            if (QuackBehavior == null) return "No quackbehavior set";

            return QuackBehavior.Quack();
        }

        public void SetNewFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }
    
    }
}
