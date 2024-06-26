using Refit;

namespace WebAPI
{
    [Headers("Content-Type: application/json")]
    public interface IServiceClient
    {
        [Get("/firstservice/WeatherForecast")]
        Task<IEnumerable<WeatherForecast>> GetFirstServiceForcast();

        [Get("/secondservice/WeatherForecast")]
        Task<IEnumerable<WeatherForecast>> GetSecondServiceForcast();
    }
}
