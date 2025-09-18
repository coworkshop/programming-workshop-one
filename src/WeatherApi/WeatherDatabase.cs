namespace WeatherApi;

public static class WeatherDatabase
{
    // [ "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" ]
    public static Task<List<WeatherTemperatureDescription>> GetTemperatureDescriptions() =>
        Task.FromResult<List<WeatherTemperatureDescription>>(
        [
            new WeatherTemperatureDescription(new TemperatureRange(-40, -30), "Freezing"),     // Extremely cold
            new WeatherTemperatureDescription(new TemperatureRange(-29, -15), "Bracing"),      // Bitterly cold
            new WeatherTemperatureDescription(new TemperatureRange(-14, -1), "Chilly"),        // Typical cold winter days
            new WeatherTemperatureDescription(new TemperatureRange(0, 5), "Cool"),             // Early spring / late autumn
            new WeatherTemperatureDescription(new TemperatureRange(6, 12), "Mild"),            // Spring / cooler summer days
            new WeatherTemperatureDescription(new TemperatureRange(13, 18), "Warm"),           // Pleasant summer
            new WeatherTemperatureDescription(new TemperatureRange(19, 24), "Balmy"),          // Typical warm summer
            new WeatherTemperatureDescription(new TemperatureRange(25, 28), "Hot"),            // Heatwave territory
            new WeatherTemperatureDescription(new TemperatureRange(29, 32), "Sweltering"),     // Rare but possible
            new WeatherTemperatureDescription(new TemperatureRange(33, 40), "Scorching")       // Extremely rare in Norway
        ]);

    public static Task<List<WeatherAverages>> GetTemperatureAverages() =>
        Task.FromResult<List<WeatherAverages>>(
        [
            // Winter
            new WeatherAverages(new DateRange(new Date(12, 1), new Date(2, 28)), "Freezing"),

            // Spring
            new WeatherAverages(new DateRange(new Date(3, 1), new Date(3, 31)), "Bracing"),
            new WeatherAverages(new DateRange(new Date(4, 1), new Date(4, 30)), "Chilly"),
            new WeatherAverages(new DateRange(new Date(5, 1), new Date(5, 31)), "Cool"),

            // Summer
            new WeatherAverages(new DateRange(new Date(6, 1), new Date(6, 30)), "Mild"),
            new WeatherAverages(new DateRange(new Date(7, 1), new Date(7, 31)), "Warm"),
            new WeatherAverages(new DateRange(new Date(8, 1), new Date(8, 31)), "Balmy"),

            // Autumn
            new WeatherAverages(new DateRange(new Date(9, 1), new Date(9, 30)), "Cool"),
            new WeatherAverages(new DateRange(new Date(10, 1), new Date(10, 31)), "Chilly"),
            new WeatherAverages(new DateRange(new Date(11, 1), new Date(11, 30)), "Bracing")
        ]);
}

public record WeatherAverages(DateRange Range, string Description);

public record Date(int Month, int Day);

public record DateRange(Date Start, Date End);

public record WeatherTemperatureDescription(TemperatureRange TemperatureRange, string Description);
public record TemperatureRange(int Min, int Max);