using System.Collections.Generic;
using Observer.observer;

namespace Observer.subject
{
    public class WeatherData : ISubject
    {   
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
         public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }
        public void RemoveObserver(IObserver o)
        {
            var observer = _observers.IndexOf(o);
            _observers.Remove(o);
        }
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}