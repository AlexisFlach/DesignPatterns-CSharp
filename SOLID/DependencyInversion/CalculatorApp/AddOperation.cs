namespace DependencyInversion.CalculatorApp
{
public class AddOperation : ICalculatorOperation
{
    public double Calculate(double x, double y)
    {
        return x + y;
    }
}
}