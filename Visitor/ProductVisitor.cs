using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IProductVisitor
    {
        void Visit(Book book);
        void Visit(Electronic electronic);
        void Visit(Grocery grocery);
    }
    class DiscountVisitor : IProductVisitor
    {
        public double DiscountedPrice { get; private set; } = 0;
        public void Visit(Book book)
        {
            DiscountedPrice = book.Price * 0.90; 
        }
        public void Visit(Electronic electronic)
        {
            DiscountedPrice = electronic.Price * 0.95;  
        }
        public void Visit(Grocery grocery)
        {
            DiscountedPrice = grocery.Price; 
        }
    }
    // Concrete Visitor for displaying descriptions
    class DescriptionVisitor : IProductVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Book: {book.Title}");
        }
        public void Visit(Electronic electronic)
        {
            Console.WriteLine($"Electronic: {electronic.Brand} {electronic.Model}");
        }
        public void Visit(Grocery grocery)
        {
            Console.WriteLine($"Grocery: {grocery.Name}, Expires on: {grocery.ExpiryDate.ToShortDateString()}");
        }
    }
}
