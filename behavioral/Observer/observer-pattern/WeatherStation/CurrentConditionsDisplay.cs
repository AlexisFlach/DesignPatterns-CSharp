namespace WeatherStation
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {   
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {   
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public string Display()
        {
            return $"Current Conditions: {_temperature} temperature + {_humidity} humidity";
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

    }
}