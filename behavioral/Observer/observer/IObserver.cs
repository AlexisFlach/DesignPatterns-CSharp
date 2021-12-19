namespace Observer.observer
{
    public interface IObserver
    {
        void Update(int temp, float humidity, float pressure);
    }
}