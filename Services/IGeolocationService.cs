using ConsoleCS_WheatherReceiver.Model.DataType;

namespace ConsoleCS_WheatherReceiver.Services
{
    public interface IGeolocationService
    {
        Task<Geolocation> GetGeolocationAsync(string cityName);
    }
}
