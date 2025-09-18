using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApi.Tests;

public class WeatherTests
{
    private readonly WeatherController _weatherController =
        new ServiceCollection()
            .AddSingleton<IWeatherService, WeatherService>()
            .AddSingleton<WeatherController>()
            .BuildServiceProvider()
            .GetRequiredService<WeatherController>();

    [Fact]
    public async Task FetchingColdestWeather_FreezingIsReturned()
    {
        var response = await _weatherController.GetColdestWeather();
        
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Freezing", weather.Description);
    }
    
    [Fact]
    public async Task FetchingHottestWeather_ScorchingIsReturned()
    {
        var response = await _weatherController.GetHottestWeather();
        
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Scorching", weather.Description);
    }
}

public class WeatherService : IWeatherService
{
    public Task<string> GetColdestWeather()
    {
        return Task.FromResult("Freezing");
    }

    public Task<string> GetHottestWeather()
    {
        return Task.FromResult("Scorching");
    }
}

[ApiController]
public class WeatherController(IWeatherService weatherService) : ControllerBase
{
    [HttpGet("weather/description/coldest")]
    public async Task<ActionResult<Weather>> GetColdestWeather()
    {
        var coldest = await weatherService.GetColdestWeather();
        var weather = new Weather(coldest);

        return weather;
    }

    [HttpGet("weather/description/hottest")]
    public async Task<ActionResult<Weather>> GetHottestWeather()
    {
        var hottest = await weatherService.GetHottestWeather();
        var weather = new Weather(hottest);

        return weather;
    }
}

public interface IWeatherService
{
    Task<string> GetColdestWeather();
    Task<string> GetHottestWeather();
}

public record Weather(string Description);