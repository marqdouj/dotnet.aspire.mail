namespace AspireMail.ApiClient
{
    public interface IApiServiceClient
    {
        INewsletterClient Newsletter { get; }
        IWeatherForecastClient WeatherForecast { get; }
    }

    public class ApiServiceClient(HttpClient httpClient) : IApiServiceClient
    {
        public INewsletterClient Newsletter { get; } = new NewsletterClient(httpClient);
        public IWeatherForecastClient WeatherForecast { get; } =  new WeatherForecastClient(httpClient);
    }
}
