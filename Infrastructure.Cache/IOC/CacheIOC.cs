using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Cache.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Cache.IOC
{
    public static class CacheIOC
    {
        public static void AddCacheServices(this IServiceCollection services)
        {
            services.AddSingleton<ICacheManager, DefaultCacheManager>();
        }
    }
}
