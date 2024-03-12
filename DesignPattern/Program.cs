namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditCard card;
            CreditCardFactory goldCardFactory = new GoldCreditCardFactory();
            card = goldCardFactory.CreateProduct();

            Console.WriteLine($"Card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit Limit: ${card.GetCreditLimit()}");


            CreditCardFactory platinumCardFactory = new PlatinumCreditCardFactory();
            card = platinumCardFactory.CreateProduct();

            Console.WriteLine($"Card Type: {card.GetCardType()}");
            Console.WriteLine($"Credit Limit: ${card.GetCreditLimit()}");

            Console.ReadLine();
        }
    }
}