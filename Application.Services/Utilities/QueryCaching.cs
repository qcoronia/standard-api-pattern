using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Caching.Services;

namespace Application.Service.Utilities
{
    public static class QueryCaching
    {
        public static IEnumerable<T> Encache<T>(this IEnumerable<T> query, ICacheManager cacheManager, string partitionKey, string hashKey)
        {
            var cache = cacheManager.Get<IEnumerable<T>>(partitionKey, hashKey);
            if (cache != null)
            {
                return cache;
            }

            cacheManager.Set(query, partitionKey, hashKey);
            return query;
        }
    }
}
