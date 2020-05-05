using software_craftsmanship.DesignPatterns.Behavioral.Strategy;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    public class CustomerShould
    {
        public CustomerShould()
        {
            _normalBillingStrategy = new NormalBillingStrategy();
            _happyHouBillingStrategy = new HappyHourBillingStrategy();
        }

        private Customer _customer;
        private readonly IBillingStrategy _normalBillingStrategy;
        private readonly IBillingStrategy _happyHouBillingStrategy;

        [Fact]
        public void Return_Customer_Bill_HappyHour()
        {
            _customer = new Customer(_happyHouBillingStrategy);
            _customer.AddDrink(Drink.Beer);

            var result = _customer.PrintBill();

            Assert.Equal(result, 2.5);
        }


        [Fact]
        public void Return_Customer_Bill_Normal()
        {
            _customer = new Customer(_normalBillingStrategy);
            _customer.AddDrink(Drink.Beer);

            var result = _customer.PrintBill();

            Assert.Equal(result, 5);
        }

        [Fact]
        public void Return_Customer_Bill_With_Mixed_Orders()
        {
            _customer = new Customer(_happyHouBillingStrategy);
            _customer.AddDrink(Drink.Beer);
            _customer.AddDrink(Drink.Cocktial);

            _customer.Strategy = _normalBillingStrategy;
            _customer.AddDrink(Drink.Beer);

            var result = _customer.PrintBill();

            Assert.Equal(result, 12.5);
        }
    }
}