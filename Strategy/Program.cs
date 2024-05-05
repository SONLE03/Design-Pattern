namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double purchaseAmount = 100.00;
            // Choose Credit Card payment
            IPaymentStrategy paymentMethod = new CreditCardPayment("1234567890123456", "12/25", "123");
            Checkout checkout = new Checkout(paymentMethod);
            checkout.CompletePurchase(purchaseAmount);
            // Choose PayPal payment
            paymentMethod = new PayPalPayment("user@example.com");
            checkout = new Checkout(paymentMethod);
            checkout.CompletePurchase(purchaseAmount);
            // Choose Cryptocurrency payment
            paymentMethod = new CryptoPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");
            checkout = new Checkout(paymentMethod);
            checkout.CompletePurchase(purchaseAmount);
            Console.ReadKey();
        }
    }
}