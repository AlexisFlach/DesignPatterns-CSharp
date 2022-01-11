using Xunit;
using WeatherStation;
namespace WeatherStation.Tests
{

public class WeatherDataTest
{
    [Fact]
    public void TestCurrentConditionsDisplay()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        weatherData.SetMeasurements(80, 65, 30);

        string expect = "Current Conditions: 80 temperature + 65 humidity";

        string actual = currentConditionsDisplay.Display();

        Assert.Equal(expect, actual);
         
    }
}
}