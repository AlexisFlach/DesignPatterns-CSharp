namespace OpenClosed.GoodOpenClosedPizza
{

    class PizzaMaker
    {
        private PizzaOven _oven;

        public PizzaMaker()
        {
            _oven = new PizzaOven();
        }
        public void MakePizza(Pizza pizza)
        {
            Console.WriteLine("Making {0} Pizza", pizza._pizzaType);
            pizza.Make(_oven);
        }
    }
    class AmericanPizza : Pizza
    {
        public AmericanPizza() : base(PizzaType.American)
        {

        }
        protected override void SetIngredients(params string[] ingredients)
        {
            base._ingredients = new PizzaIngredients(ingredients);
        }
    }

    class Pizza
    {
        protected PizzaIngredients _ingredients;

        public PizzaType _pizzaType;

        public Pizza(PizzaType type)
        {
            _pizzaType = type;
        }

        protected virtual void SetIngredients(params string[] ingredients)
        {

        }
        public void Make(PizzaOven oven)
        {
            oven.Bake(_ingredients);
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
                System.Console.WriteLine("add {0}", i);
            }
        }
    }

    public class GoodOpenClosedPizza
    {
        public static void Run()
        {
            var americanPizza = new AmericanPizza();
            var pizzaMaker = new PizzaMaker();
            pizzaMaker.MakePizza(americanPizza);
        }
    }
}