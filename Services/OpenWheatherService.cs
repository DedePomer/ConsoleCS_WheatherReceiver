using ConsoleCS_WheatherReceiver.Model.Interfaces;

namespace ConsoleCS_WheatherReceiver.Services
{
    /// <summary>
    /// Берём API с этого сайта https://openweathermap.org/api
    /// </summary>
    public class OpenWheatherService : IWheatherService
    {
        private HttpClient _httpClient;
        public OpenWheatherService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }
        public async Task<IWheather> GetWheatherAsync(string city)
        {
            throw new NotImplementedException();
        }
    }
}
