namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processing Book Order:");
            OrderProcessor book = new Book();
            book.ProcessOrder();

            Console.WriteLine("\nProcessing Ebook Order:");
            OrderProcessor ebook = new EBooks();
            ebook.ProcessOrder();

            Console.ReadKey();
        }
    }
}