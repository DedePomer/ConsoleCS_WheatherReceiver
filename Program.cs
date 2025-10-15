using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ConsoleCS_WheatherReceiver
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Configuration.AddJsonFile("Utils\\appsettings.json");

            var logPath = builder.Configuration["LogPath"];
            ArgumentNullException.ThrowIfNullOrEmpty(logPath, nameof(logPath));

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logPath)
                .CreateLogger();

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog();

            AddServices(builder.Services);

            var app = builder.Build();
            app.Run();
        }

        private static void AddServices(IServiceCollection services)
        { 
        
        }
    }
}
