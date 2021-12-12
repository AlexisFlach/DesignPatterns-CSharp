namespace OpenClosed.Pizza.Solution
{
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
}