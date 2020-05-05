namespace software_craftsmanship.DesignPatterns.Behavioral.Strategy
{
    public interface IBillingStrategy
    {
        double Calculate(double rawPrice);
    }

    public class HappyHourBillingStrategy : IBillingStrategy
    {
        public double Calculate(double rawPrice)
        {
            return rawPrice * 0.5;
        }
    }

    public class NormalBillingStrategy : IBillingStrategy
    {
        public double Calculate(double rawPrice)
        {
            return rawPrice;
        }
    }
}