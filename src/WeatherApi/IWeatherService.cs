namespace WeatherApi;

public interface IWeatherService
{
    Task<WeatherTemperatureDescription> GetColdestWeather();
    Task<WeatherTemperatureDescription> GetHottestWeather();
}