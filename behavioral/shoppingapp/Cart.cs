using shoppingapp.Entities;

namespace shoppingapp
{
    public class Cart : ISubject
    {
        private readonly List<IObserver> _observers;

        private readonly List<Item> _shopItems;


        public Cart() {
            _observers = new List<IObserver>();
            _shopItems = new List<Item>();
        }

        public void NotifyObservers()
        {
            foreach(IObserver o in _observers) {
                o.Update();
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void CartUpdated() {
            NotifyObservers();
        }

        public void AddItemToCart(Item item) {
            _shopItems.Add(item);
            CartUpdated();
        }
    }
}