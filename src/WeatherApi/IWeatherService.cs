namespace WeatherApi;

public interface IWeatherService
{
    Task<string> GetColdestWeather();
    Task<string> GetHottestWeather();
}