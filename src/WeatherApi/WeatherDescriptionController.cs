using Microsoft.AspNetCore.Mvc;

namespace WeatherApi;

[ApiController]
[Route("weather/description")]
public class WeatherDescriptionController(IWeatherService weatherService) : ControllerBase
{
    [HttpGet("coldest")]
    public async Task<ActionResult<WeatherDescription>> GetColdestWeather()
    {
        var coldest = await weatherService.GetColdestWeather();
        
        var weather = new WeatherDescription(
            coldest.TemperatureRange.Min,
            coldest.TemperatureRange.Max,
            coldest.Description);

        return weather;
    }

    [HttpGet("hottest")]
    public async Task<ActionResult<WeatherDescription>> GetHottestWeather()
    {
        var hottest = await weatherService.GetHottestWeather();
        
        var weather = new WeatherDescription(
            hottest.TemperatureRange.Min,
            hottest.TemperatureRange.Max,
            hottest.Description);

        return weather;
    }
}