namespace LiskovSubstitution
{
    public class FoodProgram
    {
        
    }

    public class Food
    {
        public virtual void GatherIngredients(string[] ingredients) {}
        public virtual void Cook() {}
    }

    public class Pizza : Food
    {
        public override void GatherIngredients(string[] ingredients)
        {
            List<string> updatedIngredients = ingredients.ToList();
            updatedIngredients.Add("Pizza base");
            updatedIngredients.Add("Ham");
        }
        public override void Cook()
        {
            base.Cook();
        }
    }
}