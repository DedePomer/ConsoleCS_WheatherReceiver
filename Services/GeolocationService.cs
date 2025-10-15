using ConsoleCS_WheatherReceiver.Model.DataType;

namespace ConsoleCS_WheatherReceiver.Services
{
    /// <summary>
    /// Берём API с этого сайта https://openweathermap.org/api/geocoding-api
    /// </summary>
    public class GeolocationService : IGeolocationService
    {
        private HttpClient _httpClient;
        public GeolocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<Geolocation> GetGeolocationAsync(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}
