namespace Directory.Build.Props.Services
{
    using MediatR;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class WeatherForecastRequest : IRequest<IEnumerable<WeatherForecast>>
    {
    }

    public class WeatherForecastHandler : IRequestHandler<WeatherForecastRequest, IEnumerable<WeatherForecast>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<IEnumerable<WeatherForecast>> Handle(WeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var rng = new Random();
            var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return Task.FromResult(weatherForecasts as IEnumerable<WeatherForecast>);
        }
    }
}
