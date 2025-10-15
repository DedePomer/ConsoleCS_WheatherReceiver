using ConsoleCS_WheatherReceiver.Services;

namespace ConsoleCS_WheatherReceiver.Pages
{
    public class ClassicPage : AbstractPage
    {
        public ClassicPage(IWheatherService wheatherService)
            : base(wheatherService)
        {

        }
    }
}
