namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoldCreditCard goldCreditCard = new GoldCreditCard();
            PlatinumCreditCard platinumCreditCard = new PlatinumCreditCard();

            Console.WriteLine(goldCreditCard.Operation());
            Console.WriteLine(platinumCreditCard.Operation());
        }
    }
}