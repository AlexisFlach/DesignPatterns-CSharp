namespace OpenClosed.Pizza.Solution
{
    class AmericanPizza : Pizza
    {
        public AmericanPizza() : base(PizzaType.American)
        {

        }
        public override void SetIngredients(params string[] ingredients)
        {
            base._ingredients = new PizzaIngredients(ingredients);
        }
    }
}