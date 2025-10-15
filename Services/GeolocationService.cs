using ConsoleCS_WheatherReceiver.Model.DataType;

namespace ConsoleCS_WheatherReceiver.Services
{
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
