namespace DependencyInversion.CalculatorApp
{
    public class CalculatorProgram
    {
        public double Add(int x, int y)
        {
            Calculator calculator = new Calculator(new AddOperation());
            double result = calculator.Solve(x, y);
            return result;
        }
        public double Subtract(int x, int y)
        {
            Calculator calculator = new Calculator(new SubtractOperation());
            double result = calculator.Solve(x, y);
            return result;
        }
    }
}