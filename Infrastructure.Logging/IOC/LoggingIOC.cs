using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Infrastructure.Logging.IOC
{
    public static class LoggingIOC
    {
        public static void AddLoggingServices(this IServiceCollection services)
        {
            services.AddSingleton<ILogger>(ctx =>
            {
                var loggerConfig = new LoggerConfiguration();
                var logger = loggerConfig.CreateLogger();
                return logger;
            });
        }
    }
}
