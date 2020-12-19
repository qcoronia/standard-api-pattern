using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Cache.Services
{
    public class DefaultCacheManager : ICacheManager
    {
        public T Get<T>(string partitionKey, string hashKey)
        {
            return default;
        }

        public void Set<T>(T data, string partitionKey, string hashKey)
        {
        }
    }
}
