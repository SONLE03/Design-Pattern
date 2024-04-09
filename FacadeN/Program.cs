namespace FacadeN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}