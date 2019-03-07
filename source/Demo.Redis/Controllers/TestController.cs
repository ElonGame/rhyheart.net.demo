using Demo.Redis.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Redis.Controllers
{
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly ICacheService _cacheService;
        public TestController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [Route("set")]
        public bool Set()
        {
             _cacheService.Set("testKey", "testValue");
            return true;
        }

        [Route("get")]
        public string Get()
        {
            return _cacheService.Get("testKey");
        }
    }
}
