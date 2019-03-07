

using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using StackExchange.Redis;

namespace Demo.Redis.Services
{
    public class RedisCacheService : ICacheService
    {
        private readonly RedisCache _redisCache;
        public RedisCacheService(RedisCache redisCache)
        {
            _redisCache = redisCache;
        }

        public void Set(string key, string value)
        {
           _redisCache.SetString(key,value);
        }

        public string Get(string key)
        {
            return _redisCache.GetString(key);
        }
    }
}
