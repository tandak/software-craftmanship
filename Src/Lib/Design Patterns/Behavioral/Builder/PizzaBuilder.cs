using System.Collections.Generic;

namespace software_craftsmanship.Lib.DesignPatterns.Behavioral.Builder
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza {Toppings = new List<Topping>()};
        }

        public PizzaBuilder SetSize(Size size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder AddTopping(Topping topping)
        {
            _pizza.Toppings.Add(topping);
            return this;
        }

        public Pizza Bake()
        {
            return _pizza;
        }
    }
}