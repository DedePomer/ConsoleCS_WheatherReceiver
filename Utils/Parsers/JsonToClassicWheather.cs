using ConsoleCS_WheatherReceiver.Model.DataType;
using System.Text.Json;

namespace ConsoleCS_WheatherReceiver.Utils.Parsers
{
    public class JsonToClassicWheather
    {
        public static ClassicWheather GetWheather(string json, string cityName)
        {
            ClassicWheather wheather;

            using JsonDocument doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            string temperature = root.GetProperty("current").GetProperty("temp").ToString();

            return wheather = new ClassicWheather()
            {
                Temperature = temperature,
                City = cityName,
            };
        }
    }
}
