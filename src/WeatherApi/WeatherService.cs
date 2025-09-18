namespace WeatherApi;

public class WeatherService : IWeatherService
{
    public async Task<WeatherTemperatureDescription> GetColdestWeather()
    {
        var temperatureDescriptions = await WeatherDatabase.GetTemperatureDescriptions();
        
        var coldest = temperatureDescriptions
            .OrderBy(td => td.TemperatureRange.Min)
            .First();

        return coldest;
    }

    public async Task<WeatherTemperatureDescription> GetHottestWeather()
    {
        var temperatureDescriptions = await WeatherDatabase.GetTemperatureDescriptions();
        
        var hottest = temperatureDescriptions
            .OrderByDescending(td => td.TemperatureRange.Max)
            .First();

        return hottest;
    }
}