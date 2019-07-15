using System;
using software_craftsmanship.Lib;

namespace software_craftsmanship.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tanda");

            //UnderstandingGenerics();
            UnderstandingYield();


            Console.ReadLine();
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

            var _panda = new Generic<Panda> { Field = new Panda()};

            Console.WriteLine("Generic.Field           = \"{0}\"", _panda.Field);
            Console.WriteLine("Generic.Field           = \"{0}\"", _panda.Field.Name);
            Console.WriteLine("Generic.Field.GetType() = {0}", _panda.Field.GetType().FullName);
        }
    }
}
