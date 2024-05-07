namespace Strategy
{
    internal class Program
    {
        public interface IShippingStrategy
        {
            double CalculateCost(double weight, string destination);
        }
        public class ExpressShipping : IShippingStrategy
        {
            public double CalculateCost(double weight, string destination)
            {
                return 10 + (2 * weight);
            }
        }
        public class StandardShipping : IShippingStrategy
        {
            public double CalculateCost(double weight, string destination)
            {
                return 5;
            }
        }
        public class EconomyShipping : IShippingStrategy
        {
            public double CalculateCost(double weight, string destination)
            {
                return 15 - (0.1 * weight);
            }
        }
        public class Order
        {
            private IShippingStrategy _shippingStrategy;
            private double _weight;
            private string _destination;
            public Order(IShippingStrategy shippingStrategy, double weight, string destination)
            {
                _shippingStrategy = shippingStrategy;
                _weight = weight;
                _destination = destination;
            }
            public double GetTotalShippingCost()
            {
                return _shippingStrategy.CalculateCost(_weight, _destination);
            }
        }
        static void Main(string[] args)
        {
            double weight = 10.00; 
            string destination = "Viet Nam"; 

            Order expressOrder = new Order(new ExpressShipping(), weight, destination);
            Console.WriteLine($"Total Shipping Cost (Express): {expressOrder.GetTotalShippingCost()}");

            Order standardOrder = new Order(new StandardShipping(), weight, destination);
            Console.WriteLine($"Total Shipping Cost (Standard): {standardOrder.GetTotalShippingCost()}");

            Order economyOrder = new Order(new EconomyShipping(), weight, destination);
            Console.WriteLine($"Total Shipping Cost (Economy): {economyOrder.GetTotalShippingCost()}");
            Console.ReadKey();


            //double purchaseAmount = 100.00;
            //// Choose Credit Card payment
            //IPaymentStrategy paymentMethod = new CreditCardPayment("1234567890123456", "12/25", "123");
            //Checkout checkout = new Checkout(paymentMethod);
            //checkout.CompletePurchase(purchaseAmount);
            //// Choose PayPal payment
            //paymentMethod = new PayPalPayment("user@example.com");
            //checkout = new Checkout(paymentMethod);
            //checkout.CompletePurchase(purchaseAmount);
            //// Choose Cryptocurrency payment
            //paymentMethod = new CryptoPayment("1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa");
            //checkout = new Checkout(paymentMethod);
            //checkout.CompletePurchase(purchaseAmount);
            //Console.ReadKey();
        }
    }
}