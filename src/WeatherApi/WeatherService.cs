namespace WeatherApi;

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