using Observer.observer;

namespace Observer.subject
{
    public interface ISubject
    {
         void RegisterObserver(IObserver o);
         void RemoveObserver(IObserver o);
         void NotifyObserver();
    }
}