using System;
using System.Management;
using software_craftsmanship.Lib;
using software_craftsmanship.Lib.Cache;
using software_craftsmanship.Lib.Extensions;
using StackExchange.Redis;

namespace software_craftsmanship.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tanda");

            // UnderstandingGenerics();
            // UnderstandingYield();

            //var summary = BenchmarkRunner.Run<BenchmarkingDifferentApproaches>();

            //UnderstandingMemoryCache();

            UnderstandingRedisCache();

            Console.ReadLine();
        }

        private static void UnderstandingMemoryCache()
        {
            var product = new Product(Department.WS, 0987, "ASOS Design Dress", 20.00);

            var cache = new MemoryCacheDemo();

            cache.AddToCache(product);

            var product1 = cache.ReadFromCache(product.Id);
            var product2 = cache.ReadFromCache(1234);

            Console.WriteLine(product1.ToProductString());
            Console.WriteLine(product2.ToProductString());
        }

        public static void UnderstandingRedisCache()
        {
            var cache = new RedisCacheConnectorHelper();

            cache.AddToCache(null);
            cache.ReadFromCache(1);
        }

        private static void UnderstandingYield()
        {
            var yield = new Yield();
        }

        private static void UnderstandingGenerics()
        {
            var _foo = new Generic<string> {Field = "A string"};

            Console.WriteLine("Generic.Field           = \"{0}\"", _foo.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", _foo.Field.GetType().FullName);

            var _bar = new Generic<int> {Field = 27};

            Console.WriteLine("Generic.Field           = \"{0}\"", _bar.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", _bar.Field.GetType().FullName);

            var _panda = new Generic<Panda> {Field = new Panda()};

            Console.WriteLine("Generic.Field           = \"{0}\"", _panda.Field);
            Console.WriteLine("Generic.Field           = \"{0}\"", _panda.Field.Name);
            Console.WriteLine("Generic.Field.GetType() = {0}", _panda.Field.GetType().FullName);
        }
    }
}