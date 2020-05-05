using software_craftsmanship.DesignPatterns.Behavioral.Strategy;
using Xunit;

namespace software_craftsmanship.Lib.UnitTests
{
    public class BillingStrategyShould
    {
        private IBillingStrategy _billingStrategy;

        [Fact]
        public void HappyHour_Billing_Strategy_Returns_Discount_Price()
        {
            _billingStrategy = new HappyHourBillingStrategy();
            var result = _billingStrategy.Calculate(10);

            Assert.True(result.Equals(5));
        }

        [Fact]
        public void Normal_Billing_Strategy_Returns_Raw_Price()
        {
            _billingStrategy = new NormalBillingStrategy();
            var result = _billingStrategy.Calculate(10);
            Assert.True(result.Equals(10));
        }
    }
}