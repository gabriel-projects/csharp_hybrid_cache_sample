using Api.GRRInnovations.Hybrid.Cache.Sample.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GRRInnovations.Hybrid.Cache.Sample.Infrastructure.Caching
{
    public class HybridCacheService : IHybridCacheService
    {
        public Task<T?> GetOrCreateAsync<T>(string cacheKey, TimeSpan ttl, Func<Task<T>> factory) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
