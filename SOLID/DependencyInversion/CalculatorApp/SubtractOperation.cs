namespace DependencyInversion.CalculatorApp
{
    public class SubtractOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x -y;
        }
    }
}