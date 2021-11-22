namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            return pizza;
        }
    }
}