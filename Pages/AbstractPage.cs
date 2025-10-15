using ConsoleCS_WheatherReceiver.Services;

namespace ConsoleCS_WheatherReceiver.Pages
{
    public abstract class AbstractPage
    {
        protected IWheatherService _wheatherService;
        protected AbstractPage(IWheatherService wheatherService)
        {
            _wheatherService = wheatherService;
        }
    }
}
