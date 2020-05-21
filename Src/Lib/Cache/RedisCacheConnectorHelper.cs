using System;
using StackExchange.Redis;

namespace software_craftsmanship.Lib.Cache
{
    public class RedisCacheConnectorHelper :ICache
    {
        static RedisCacheConnectorHelper()
        {
            RedisCacheConnectorHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect("localhost");
            });
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }

        public bool AddToCache(Product product)
        {
            var devicesCount = 10000;
            var rnd = new Random();
            var cache = Connection.GetDatabase();

            for (int i = 1; i < devicesCount; i++)
            {
                var value = rnd.Next(0, 10000);
                cache.StringSet($"Device_Status:{i}", value);
            }

            return true;
        }

        public Product ReadFromCache(int productId)
        {
            var cache = Connection.GetDatabase();
            var count = 10000;
            for (int i = 0; i < count; i++)
            {
                var value = cache.StringGet($"Panda_Status:{i}");
                Console.WriteLine($"Panda Id={value}");
            }

            return null;
        }
    }
}