namespace OpenClosed.Pizza.Solution
{
    public class PizzaSimulation
    {
        public static void Run()
        {
            var americanPizza = new AmericanPizza();
            var pizzaMaker = new PizzaStore();
            pizzaMaker.MakePizza(americanPizza);
        }
    }
}