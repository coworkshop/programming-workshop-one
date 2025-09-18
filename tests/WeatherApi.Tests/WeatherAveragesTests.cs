using Microsoft.Extensions.DependencyInjection;

namespace WeatherApi.Tests;

public class WeatherAveragesTests
{
    private readonly WeatherAveragesController _weatherAveragesController =
        new ServiceCollection()
            .AddSingleton<IWeatherService, WeatherService>()
            .AddSingleton<WeatherAveragesController>()
            .BuildServiceProvider()
            .GetRequiredService<WeatherAveragesController>();
}