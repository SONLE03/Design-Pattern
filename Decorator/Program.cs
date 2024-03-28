namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportsCar = new SportsCar(new ConcreteCar());
            sportsCar.Assemble();
            Console.WriteLine("\n*****");

            var sportsLuxuryCar = new SportsCar(new LuxuryCar(new ConcreteCar()));
            sportsLuxuryCar.Assemble();
        }
    }
}