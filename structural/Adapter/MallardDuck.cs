namespace Adapter
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            System.Console.WriteLine("Quack!");
        }

        public void Quack()
        {
            System.Console.WriteLine("Flying");
        }
    }
}