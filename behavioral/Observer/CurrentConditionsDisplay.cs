using System;
using Observer.observer;
using Observer.subject;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {   
        private float _temperature;
        private float _humidity;
        private float _pressure;

        private ISubject _weatherdata;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherdata = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + " degrees and " + _humidity + "% humidity");
        }

        public void Update(int temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}