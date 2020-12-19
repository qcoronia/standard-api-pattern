using System;
using System.Collections.Generic;
using System.Text;
using Application.Service.Scope.Aggregate;
using Data.Repository.IOC;
using Infrastructure.Caching.IOC;
using Infrastructure.Logging.IOC;
using Infrastructure.Messaging.IOC;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Service.IOC
{
    public static class ServiceIOC
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAggregateService, AggregateService>();

            // DataLayer Services
            services.AddRepositoryServices();

            // Infrastructure Services
            services.AddMessagingServices();
            services.AddLoggingServices();
            services.AddCacheServices();
        }
    }
}
