namespace Observer
{
    internal class Program
    {
        public interface ICustomer
        {
            void Notify(Product product);
        }
        // Concrete Observer: Customer
        public class Customer : ICustomer
        {
            public string CustomerName { get; private set; }
            public Customer(string name)
            {
                CustomerName = name;
            }
            public void Notify(Product product)
            {
                Console.WriteLine($"{CustomerName}, the price of {product.ProductName} has changed to ${product.Price}!");
            }
        }
        // Subject Interface
        public interface IProduct
        {
            void AddWatcher(ICustomer customer);
            void RemoveWatcher(ICustomer customer);
            void NotifyWatchers();
        }
        // Concrete Subject: Product
        public class Product : IProduct
        {
            private List<ICustomer> _customers = new List<ICustomer>();
            public string ProductName { get; private set; }
            private double _price;
            public Product(string name, double price)
            {
                ProductName = name;
                _price = price;
            }
            public double Price
            {
                get { return _price; }
                set
                {
                    if (_price != value)
                    {
                        _price = value;
                        NotifyWatchers();
                    }
                }
            }
            public void AddWatcher(ICustomer customer)
            {
                _customers.Add(customer);
            }
            public void RemoveWatcher(ICustomer customer)
            {
                _customers.Remove(customer);
            }
            public void NotifyWatchers()
            {
                foreach (var customer in _customers)
                {
                    customer.Notify(this);
                }
            }
        }
        static void Main(string[] args)
        {
            Product TShirt = new Product("T-Shirt", 30.00);
            Customer Alice = new Customer("Alice");
            Customer Bob = new Customer("Bob");
            Customer Charlie = new Customer("Charlie");

            // AddWatcher
            TShirt.AddWatcher(Alice);   // Alice wants to watch the price of the T-Shirt
            TShirt.AddWatcher(Bob);     // Bob wants to watch the price of the T-Shirt
            TShirt.AddWatcher(Charlie); // Charlie also wants to watch the price of the T-Shirt

            // RemoveWatcher
            TShirt.RemoveWatcher(Bob);

            // Simulating a price change
            TShirt.Price = 25.00;

            Console.ReadKey();
        }
    }
}