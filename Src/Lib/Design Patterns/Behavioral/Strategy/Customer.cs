using System.Collections.Generic;
using System.Linq;

namespace software_craftsmanship.DesignPatterns.Behavioral.Strategy
{
    public class Customer
    {
        private readonly List<double> _drinks = new List<double>();

        public Customer(IBillingStrategy strategy)
        {
            Strategy = strategy;
        }

        public IBillingStrategy Strategy { get; set; }

        public void AddDrink(Drink drink)
        {
            _drinks.Add(Strategy.Calculate((int) drink));
        }

        public double PrintBill()
        {
            return _drinks.Sum();
        }
    }
}