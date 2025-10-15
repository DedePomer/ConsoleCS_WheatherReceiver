using ConsoleCS_WheatherReceiver.Services;

namespace ConsoleCS_WheatherReceiver.Pages
{
    public class ClassicPage : AbstractPage
    {

        public ClassicPage(IWheatherService wheatherService)
            : base(wheatherService)
        {            
        }

        public async Task Open()
        {   
            string temperature = (await _wheatherService.GetWheatherAsync("Moscow")).Temperature;
            Console.WriteLine($"Температура в Москве {temperature}");
        }
    }
}
