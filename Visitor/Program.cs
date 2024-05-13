namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct book = new Book { Price = 100, Title = "Design Patterns" };
            IProduct laptop = new Electronic { Price = 1000, Brand = "Dell", Model = "XPS 15" };
            IProduct apple = new Grocery { Price = 2, Name = "Apple", ExpiryDate = DateTime.Now.AddDays(10) };
            var discountVisitor = new DiscountVisitor();
            var descriptionVisitor = new DescriptionVisitor();
            book.Accept(discountVisitor);
            Console.WriteLine($"Discounted Price of Book: ${discountVisitor.DiscountedPrice}");
            book.Accept(descriptionVisitor);
            laptop.Accept(discountVisitor);
            Console.WriteLine($"Discounted Price of Laptop: ${discountVisitor.DiscountedPrice}");
            laptop.Accept(descriptionVisitor);
            apple.Accept(discountVisitor);
            Console.WriteLine($"Discounted Price of Apple: ${discountVisitor.DiscountedPrice}");
            apple.Accept(descriptionVisitor);
            Console.ReadKey();
        }
    }
}