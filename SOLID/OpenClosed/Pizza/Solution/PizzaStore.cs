namespace OpenClosed.Pizza.Solution
{
    class PizzaStore
    {
        private PizzaOven _oven;

        public PizzaStore()
        {
            _oven = new PizzaOven();
        }
        public void MakePizza(Pizza pizza)
        {
            Console.WriteLine("Making {0} Pizza", pizza._pizzaType);
            pizza.SetIngredients("Cheese", "Ham");
            pizza.Make(_oven);
        }
    }
}