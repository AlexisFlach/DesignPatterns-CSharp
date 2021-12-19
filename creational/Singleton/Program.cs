using Singleton.Singleton;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Unique singletonA = Unique.getInstance();
            Unique singletonB = Unique.getInstance();
            Console.WriteLine(singletonA == singletonB);
        }
    }
}
