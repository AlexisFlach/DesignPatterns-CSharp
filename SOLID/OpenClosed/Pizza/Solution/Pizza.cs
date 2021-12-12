namespace OpenClosed.Pizza.Solution
{
    class Pizza
    {
        protected PizzaIngredients _ingredients;

        public PizzaType _pizzaType;

        public Pizza(PizzaType type)
        {
            _pizzaType = type;
        }

        public virtual void SetIngredients(params string[] ingredients)
        {

        }
        public void Make(PizzaOven oven)
        {
            oven.Bake(_ingredients);
        }
    }
}