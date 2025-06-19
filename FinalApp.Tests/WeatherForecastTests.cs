using Xunit;
using FinalApp.Models;

namespace FinalApp.Tests;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_CalculatesCorrectly()
    {
        var forecast = new WeatherForecast { TemperatureC = 0 };
        Assert.Equal(32, forecast.TemperatureF);
    }
}
