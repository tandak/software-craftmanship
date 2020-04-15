using System.Diagnostics;
using software_craftsmanship.ConsoleApp;

namespace software_craftsmanship.Lib
{
    public class Yield
    {
        public static void ShowPandas()
        {
            var p = new Pandas();
            foreach (var poo in p.PandaZoo)
                Debug.WriteLine($"Name: {poo.Name}, Age: {poo.Age}, Location: {poo.Location}");
        }
    }
}