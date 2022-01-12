namespace Cafe
{
    public abstract class Beverage
    {
        public string Description = "Unkown Beverage";
        public virtual string GetDescription() => Description;
        public abstract double Cost();
    }
}