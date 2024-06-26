using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IServiceClient _client;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IServiceClient client)
        {
            _logger = logger;
            _client = client;
        }

        [HttpGet]
        [Route("GetWeatherForecastFirstService")]
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForcastFromFirstService()
        {
            return await _client.GetFirstServiceForcast();
        }

        [HttpGet]
        [Route("GetWeatherForecastSecondService")]
        public async Task<IEnumerable<WeatherForecast>> GetWeatherForcastFromSecondService()
        {
            return await _client.GetSecondServiceForcast();
        }
    }
}
