namespace DuckSim
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackBehavior();
        }
        public override string Display()
        {
            return "I am a Mallard Duck";
        }

      
    }
}