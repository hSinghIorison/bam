using System.ServiceModel;

namespace Bam.WeatherForecast.Service
{
    [ServiceContract]
    public interface IWeatherForecastService
    {

        [OperationContract]
        ForecastResponse GetWeatherForecastData(ForecastRequest data);
    }
}
