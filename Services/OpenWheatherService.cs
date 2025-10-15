using ConsoleCS_WheatherReceiver.Model.DataType;
using ConsoleCS_WheatherReceiver.Model.Interfaces;
using ConsoleCS_WheatherReceiver.Utils.Constants;
using ConsoleCS_WheatherReceiver.Utils.Parsers;

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
            Geolocation geolocation = await _geolocationService.GetGeolocationAsync(city);
            string url = $"http://api.openweathermap.org/data/3.0/onecall?lat={geolocation.Latitude}&lon={geolocation.Longitude}&units=metric&exclude=current&appid={HttpConstants.OPEN_WHEATHER_API_KEY}";

            var responce = await _httpClient.GetAsync(url);

            if (responce.IsSuccessStatusCode)
            {
                string json = await responce.Content.ReadAsStringAsync();
                return JsonToClassicWheather.GetWheather(json, city);
            }
            else 
            {
                throw new Exception("Ошибка получения данных");
            }

        }
    }
}
