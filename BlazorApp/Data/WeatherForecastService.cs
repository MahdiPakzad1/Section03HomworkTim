namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IConfiguration config;

        public WeatherForecastService(IConfiguration config)
        {
            this.config = config;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {

            int maxValue = config.GetValue<int>("WeatherForcast:WeatherForcastDays");

            return Task.FromResult(Enumerable.Range(1, maxValue).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
