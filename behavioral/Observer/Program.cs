using Observer.subject;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = 
                new CurrentConditionsDisplay(weatherData);

                weatherData.SetMeasurements(80, 18, 19);
        }
    }
}
