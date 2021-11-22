namespace SimpleFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza("cheese");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}