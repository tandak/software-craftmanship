using System;
using System.Runtime.Caching;

namespace software_craftsmanship.Lib.Cache
{
    public class MemoryCacheDemo : ICache
    {
        private readonly MemoryCache _memoryCache;
        private readonly CacheItemPolicy _cacheItemPolicy;

        public MemoryCacheDemo()
        {
            //Cache Setup
            _memoryCache = new MemoryCache("demoCache");

            //Cache - entry item creation
            var product = new Product(Department.MW, 1234, "Nike Tee", 45.00);
            var cacheItem = new CacheItem(product.Id.ToString(), product);

            //Policy 
            _cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60.0)
            };

            //Initial Add
            _memoryCache.Add(cacheItem, _cacheItemPolicy);
        }

        public bool AddToCache(Product product)
        {
            var cacheItem = new CacheItem(product.Id.ToString(), product);
            return _memoryCache.Add(cacheItem, _cacheItemPolicy);
        }

        public Product ReadFromCache(int productId)
        {
            var result = (Product)_memoryCache.Get(productId.ToString());
            return result;
        }
    }
}
