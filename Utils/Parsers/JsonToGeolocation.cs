using System.Text.Json;
using ConsoleCS_WheatherReceiver.Model.DataType;

namespace ConsoleCS_WheatherReceiver.Utils.Parsers
{
    public static class JsonToGeolocation
    {
        public static Geolocation GetGeolocation(string json)
        {
            Geolocation geolocation;

            using JsonDocument doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            string latitude = root.GetProperty("lat").ToString();
            string longitude = root.GetProperty("lon").ToString();

            return geolocation = new Geolocation() 
            {
                Latitude = latitude,
                Longitude = longitude
            };
        }
    }
}
