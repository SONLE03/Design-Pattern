namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCache cache = new BookCache();

            // Fetch a book for the first time
            Book book1 = cache.GetBook(123456);
            Console.WriteLine($"Retrieved book: {book1.Title} by {book1.Author}");

            // Fetch the same book again, this time it should come from the cache
            Book book2 = cache.GetBook(123456);
            Console.WriteLine($"Retrieved book: {book2.Title} by {book2.Author}");

            // Verify that a clone was returned
            Console.WriteLine($"Are book1 and book2 the same instance? {(book1 == book2 ? "Yes" : "No")}");
        }
    }
}