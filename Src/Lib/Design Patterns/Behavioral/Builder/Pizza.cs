using System.Collections.Generic;

namespace software_craftsmanship.Lib.DesignPatterns.Behavioral.Builder
{
    public class Pizza
    {
        public List<Topping> Toppings { get; set; }
        public Size Size { get; set; }
    }
}