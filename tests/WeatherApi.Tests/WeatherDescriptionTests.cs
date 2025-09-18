using Microsoft.Extensions.DependencyInjection;

namespace WeatherApi.Tests;

/// <summary>
/// Guidelines for writing maintainable and readable tests:
/// 
/// <list type="bullet">
/// <item>
/// <description>
/// <b>Test from the Outside-In with a focus on use cases:</b> 
/// Start with a single, best-case test for the main use case. Follow up with supporting tests as needed, 
/// e.g., verifying correct behavior when handling exceptions, logging, or retrying external services.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Keep separate tests in separate test classes:</b> 
/// Tests targeting different parts of the application should be in separate classes, each with its own setup.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Name tests using Given-When-Then:</b> 
/// Follow the BDD-style naming convention (<see href="https://martinfowler.com/bliki/GivenWhenThen.html"/>)
/// to make tests readable for both technical and non-technical team members.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Group test code using Arrange-Act-Assert:</b> 
/// Organize test logic clearly to improve readability and understanding.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Be specific on assertions:</b> 
/// Each assert should be focused on the behavior being tested. Multiple asserts are allowed as long as they are meaningful.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Abstract away noise and magic values:</b> 
/// Remove irrelevant details that do not contribute to understanding the test, making it easier to grasp at first sight.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Reserve mocks and fakes for external dependencies:</b> 
/// Use mocks or fakes only when you cannot control the code, e.g., calling external services or working with dates and time.
/// Prefer testing from the outside-in whenever possible.
/// </description>
/// </item>
/// 
/// <item>
/// <description>
/// <b>Treat test code as production code:</b> 
/// Refactor and question the purpose of your tests. Maintain clarity and quality just like application code.
/// </description>
/// </item>
/// </list>
/// </summary>
public class WeatherDescriptionTests
{
    private readonly WeatherDescriptionController _weatherDescriptionController =
        new ServiceCollection()
            .AddSingleton<IWeatherService, WeatherService>()
            .AddSingleton<WeatherDescriptionController>()
            .BuildServiceProvider()
            .GetRequiredService<WeatherDescriptionController>();

    [Fact]
    public async Task TestFreezing()
    {
        var response = await _weatherDescriptionController.GetColdestWeather();
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Freezing", weather.Description);
        Assert.Equal(-40, weather.Coldest);
        Assert.Equal(-30, weather.Hottest);
    }
    
    [Fact]
    public async Task TestHottest()
    {
        var response = await _weatherDescriptionController.GetHottestWeather();
        var weather = response.Value;
        Assert.NotNull(weather);
        Assert.Equal("Scorching", weather.Description);
        Assert.Equal(33, weather.Coldest);
        Assert.Equal(40, weather.Hottest);
    }
}