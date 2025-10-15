using ConsoleCS_WheatherReceiver.Model.DataType;
using ConsoleCS_WheatherReceiver.Utils.Constants;
using ConsoleCS_WheatherReceiver.Utils.Parsers;

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
        public async Task<Geolocation> GetGeolocationAsync(string cityName)
        {
            string url = $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&limit={1}&appid={HttpConstants.OPEN_WHEATHER_API_KEY}";
            var responce = await _httpClient
                .GetAsync(url);
            if (responce.IsSuccessStatusCode)
            {
                string json = await responce.Content.ReadAsStringAsync();
                return JsonToGeolocation.GetGeolocation(json);
            }
            else 
            {
                throw new Exception("Ошибка получения данных");
            }
        }
    }
}
