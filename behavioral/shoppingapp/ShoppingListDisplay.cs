namespace shoppingapp
{
    public class ShoppingListDisplay : IObserver, IDisplayElement
    {
        private ISubject _cart;

        public ShoppingListDisplay(ISubject cart)
        {
            _cart = cart;
            _cart.RegisterObserver(this);
            
        }

        public void Update() {
            Display();
        }
        public void Display()
        {
            System.Console.WriteLine("added item to cart");
        }
    }
}