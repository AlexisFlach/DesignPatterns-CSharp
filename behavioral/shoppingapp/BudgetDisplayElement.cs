namespace shoppingapp
{
    public class BudgetDisplayElement : IDisplayElement, IObserver, ICalculatable
    {
        private ISubject _cart;
        private int _budget = 0;

        public BudgetDisplayElement(ISubject cart, int budget)
        {   
            _budget = budget;
            _cart = cart;
            _cart.RegisterObserver(this);
            
        }

        public void Display()
        {
            System.Console.WriteLine("You have left: " + _budget);
        }

        public void SubtractFromBudget(int itemPrice)
        {
            _budget = _budget - itemPrice;
        }

        public void Update()
        {   
            SubtractFromBudget();
            Display();
        }
    }
}