namespace StrategyDesignPattern
{
    public class PaymentStrategy
    {


        public class CreditCardPaymentStrategy : IPaymentStrategy
        {
            public void ProcessPayment(double amount)
            {
                // Implement credit card payment processing here
                Console.WriteLine($"Payment done by Credit Card : {amount} Rs. ");
            }
        }

        public class PayPalPaymentStrategy : IPaymentStrategy
        {
            public void ProcessPayment(double amount)
            {
                // Implement PayPal payment processing here
                Console.WriteLine($"Payment done by PayPal  : {amount} Rs. ");
            }
        }

        public class CryptocurrencyPaymentStrategy : IPaymentStrategy
        {
            public void ProcessPayment(double amount)
            {
                // Implement cryptocurrency payment processing here
                Console.WriteLine($"Payment done by cryptocurrency  : {amount} Rs. ");

            }
        }

    }
}
