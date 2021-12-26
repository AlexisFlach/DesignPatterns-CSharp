using Adapter;

public class DuckTestDrive
{
    public static void Main(string[] args)
    {
        IDuck duck = new MallardDuck();
        ITurkey turkey = new WildTurkey();

        IDuck turkeyAdapter = new TurkeyAdapter(turkey);

        TestDuck(turkeyAdapter);
    }
    public static void TestDuck(IDuck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}