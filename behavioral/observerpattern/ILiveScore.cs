namespace observerpattern
{
    public interface ILiveScore
    {
        void RegisterObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
        void NotifyObservers();
    }
}