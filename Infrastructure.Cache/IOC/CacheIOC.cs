using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Caching.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Caching.IOC
{
    public static class CacheIOC
    {
        public static void AddCacheServices(this IServiceCollection services)
        {
            services.AddSingleton<ICacheManager, DefaultCacheManager>();
        }
    }
}
