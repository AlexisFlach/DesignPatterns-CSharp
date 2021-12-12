namespace OpenClosed.Pizza
{
    class PizzaStore
    {
        private PizzaOven _oven;
        public PizzaStore()
        {
            _oven = new PizzaOven();
        }

        public void MakePizza(PizzaType type)
        {
            PizzaIngredients pizzaIngredients;
            switch (type)
            {
                case PizzaType.American:
                    pizzaIngredients = new PizzaIngredients("Tripple cheese", "Bacon");
                    _oven.Bake(pizzaIngredients);
                    pizzaIngredients.PrintIngredients();
                    break;
                case PizzaType.Italian:
                    pizzaIngredients = new PizzaIngredients("Tomato Sauce", "Cheese");
                    _oven.Bake(pizzaIngredients);
                    break;
                case PizzaType.Vegetarian:
                    pizzaIngredients = new PizzaIngredients("Sallad");
                    _oven.Bake(pizzaIngredients);
                    break;
                default:
                    break;

            }
        }
    }

    enum PizzaType
    {
        Vegetarian,
        Italian,
        American
    }

    class PizzaOven
    {
        public void Bake(PizzaIngredients ingredients)
        {
        }
    }
    class PizzaIngredients
    {
        private readonly List<string> _ingredients = new List<string>();
        public PizzaIngredients(params string[] ingredients)
        {
            foreach (string i in ingredients)
            {
                _ingredients.Add(i);
            }
        }
        public void PrintIngredients()
        {
            foreach (var item in _ingredients)
            {
                System.Console.WriteLine(item);
            }
        }
    }
    public class BadPizza
    {
        public static void Run()
        {
            var pizzaStore = new PizzaStore();
            pizzaStore.MakePizza(PizzaType.American);
        }

    }

}