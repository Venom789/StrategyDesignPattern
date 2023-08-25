using static StrategyDesignPattern.PaymentStrategy;

namespace StrategyDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            double paymentAmount = 100.00;

            PaymentContext context = new PaymentContext(new CreditCardPaymentStrategy());
            context.ProcessPayment(paymentAmount);

            // You can switch to a different payment strategy at runtime
            context.SetPaymentStrategy(new PayPalPaymentStrategy());
            context.ProcessPayment(paymentAmount);

            context.SetPaymentStrategy(new CryptocurrencyPaymentStrategy());
            context.ProcessPayment(paymentAmount);
        }
    }
}