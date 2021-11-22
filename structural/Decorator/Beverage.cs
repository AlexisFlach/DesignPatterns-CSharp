namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description;
       public virtual string GetDescription()
    {
        return _description;
    }
        public abstract double Cost();
    }
}