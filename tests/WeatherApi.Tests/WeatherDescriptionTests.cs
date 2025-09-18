using Microsoft.Extensions.DependencyInjection;

namespace WeatherApi.Tests;

public class WeatherDescriptionTests
{
    private readonly WeatherDescriptionController _weatherDescriptionController =
        new ServiceCollection()
            .AddSingleton<IWeatherService, WeatherService>()
            .AddSingleton<WeatherDescriptionController>()
            .BuildServiceProvider()
            .GetRequiredService<WeatherDescriptionController>();

    [Fact]
    public async Task FetchingColdestWeather_FreezingIsReturned()
    {
        var response = await _weatherDescriptionController.GetColdestWeather();
        
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Freezing", weather.Description);
    }
    
    [Fact]
    public async Task FetchingHottestWeather_ScorchingIsReturned()
    {
        var response = await _weatherDescriptionController.GetHottestWeather();
        
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Scorching", weather.Description);
    }
}