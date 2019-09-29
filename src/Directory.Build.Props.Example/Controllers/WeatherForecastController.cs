namespace Directory.Build.Props.Example.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Directory.Build.Props.Services;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> logger;
        private readonly IMediator mediator;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMediator mediator
        )
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        public Task<IEnumerable<WeatherForecast>> Get()
        {
            logger.LogInformation("Weather forecast request received");
            return mediator.Send(new WeatherForecastRequest());
        }
    }
}
