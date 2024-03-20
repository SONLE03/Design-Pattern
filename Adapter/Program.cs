namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var captain = new Captain(new FishingBoatAdapter());
            captain.Row();
        }
    }
}