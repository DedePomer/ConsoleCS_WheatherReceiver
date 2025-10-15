using ConsoleCS_WheatherReceiver.Model.Interfaces;

namespace ConsoleCS_WheatherReceiver.Model.DataType
{
    public class ClassicWheather : IWheather
    {
        public required string City { get; init; }
        public required string Temperature { get; init; }
        public required int Population { get; init; }
    }
}
