using ConsoleCS_WheatherReceiver.Model.Interfaces;

namespace ConsoleCS_WheatherReceiver.Services
{
    public interface IWheatherService
    {
        Task<IWheather> GetWheatherAsync(string city);
    }
}
