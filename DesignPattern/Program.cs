namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CreditCardFactory goldCardFactory = new GoldCreditCardFactory();
            ICreditCard goldCard = goldCardFactory.CreateProduct();

            Console.WriteLine($"Card Type: {goldCard.GetCardType()}");
            Console.WriteLine($"Credit Limit: ${goldCard.GetCreditLimit()}");


            CreditCardFactory platinumCardFactory = new PlatinumCreditCardFactory();
            ICreditCard platinumCard = platinumCardFactory.CreateProduct();

            Console.WriteLine($"Card Type: {platinumCard.GetCardType()}");
            Console.WriteLine($"Credit Limit: ${platinumCard.GetCreditLimit()}");

            Console.ReadLine();
        }
    }
}