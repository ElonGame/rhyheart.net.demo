using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Redis.Services
{
    public interface ICacheService
    {
        void Set(string key, string value);
        string Get(string key);
    }
}
