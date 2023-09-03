namespace C_Sharp_Study; 

public class WeatherForecastService {
    private static string[] summaries = new[] {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate) {
        var rng = new Random();
        return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForecast {
            Date = startDate.AddDays(idx),
            TemperatureC = rng.Next(-20, 55),
            Summary = summaries[rng.Next(summaries.Length)]
        }).ToArray());
    }
}