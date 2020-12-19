using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Caching.Services
{
    public interface ICacheManager
    {
        T Get<T>(string partitionKey, string hashKey);

        void Set<T>(T data, string partitionKey, string hashKey);
    }
}
