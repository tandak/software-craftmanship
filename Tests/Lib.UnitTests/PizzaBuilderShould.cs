using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using software_craftsmanship.Lib.DesignPatterns.Behavioral.Builder;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    public class PizzaBuilderShould
    {
        public PizzaBuilderShould()
        {
            _pizzaBuilder = new PizzaBuilder();
        }

        private readonly PizzaBuilder _pizzaBuilder;

        [Fact]
        public void Create_A_Large_Pizza()
        {
            var pizza = _pizzaBuilder
                .SetSize(Size.Large)
                .Bake();

            pizza.Size.Should().Be(Size.Large);
        }

        [Fact]
        public void Create_Large_Pizza_With_One_Topping()
        {
            var pizza = _pizzaBuilder
                .SetSize(Size.Large)
                .AddTopping(Topping.Pepperoni)
                .Bake();

            pizza.Size.Should().Be(Size.Large);
            pizza.Toppings.Count.Should().Be(1);
            pizza.Toppings.Contains(Topping.Pepperoni);
        }

        [Fact]
        public void Create_Small_Pizza_With_Two_Toppings()
        {
            var pizza = _pizzaBuilder
                .SetSize(Size.Small)
                .AddTopping(Topping.Cheese)
                .AddTopping(Topping.Pepperoni)
                .Bake();

            var expectedToppings = new List<Topping>
            {
                Topping.Cheese,
                Topping.Pepperoni
            };

            pizza.Size.Should().Be(Size.Small);
            pizza.Toppings.Count.Should().Be(2);
            Assert.True(pizza.Toppings.All(expectedToppings.Contains));
        }
    }
}