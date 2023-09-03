using System;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_Study {
    static class C_Sharp_Study {
        public static async Task Main() {
            var service = new WeatherForecastService();
            var forecasts = await service.GetForecastAsync(DateTime.Now);
            
            Console.WriteLine("Date\tTemp. (C)\tSummary");
            
            foreach (var forecast in forecasts) {
                Console.WriteLine($"{forecast.Date.ToShortDateString()}\t" + $"{forecast.TemperatureC}\t{forecast.Summary}");
            }
        }
    }   
}