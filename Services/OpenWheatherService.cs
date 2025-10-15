using ConsoleCS_WheatherReceiver.Model.Interfaces;

namespace ConsoleCS_WheatherReceiver.Services
{
    /// <summary>
    /// Берём API с этого сайта https://openweathermap.org/api
    /// </summary>
    public class OpenWheatherService : IWheatherService
    {
        private HttpClient _httpClient;
        private IGeolocationService _geolocationService;
        public OpenWheatherService(HttpClient httpClient, IGeolocationService geolocationService) 
        {
            _httpClient = httpClient;
            _geolocationService = geolocationService;
        }
        public async Task<IWheather> GetWheatherAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}
