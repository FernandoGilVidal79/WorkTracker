using Microsoft.Extensions.DependencyInjection;
using WorkTrackerAPI.Infrastructure.Contracts;
using WorkTrackerAPI.Infrastructure;

namespace WorkTrackerAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureNLogService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}