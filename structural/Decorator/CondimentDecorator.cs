using Decorator;

namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}