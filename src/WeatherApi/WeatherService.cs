namespace WeatherApi;

public class WeatherService : IWeatherService
{
    public async Task<string> GetColdestWeather()
    {
        var temperatureDescriptions = await WeatherDatabase.GetTemperatureDescriptions();
        
        var coldest = temperatureDescriptions
            .OrderBy(td => td.TemperatureRange.Min)
            .First();

        return coldest.Description;
    }

    public async Task<string> GetHottestWeather()
    {
        var temperatureDescriptions = await WeatherDatabase.GetTemperatureDescriptions();
        
        var hottest = temperatureDescriptions
            .OrderByDescending(td => td.TemperatureRange.Max)
            .First();

        return hottest.Description;
    }
}