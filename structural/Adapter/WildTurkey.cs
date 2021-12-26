namespace Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying!");
        }

        public void Gobble()
        {
            System.Console.WriteLine("Gobble!");
        }
    }
}