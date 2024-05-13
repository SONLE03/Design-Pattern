using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IProduct
    {
        void Accept(IProductVisitor visitor);
    }
    class Book : IProduct
    {
        public double Price { get; set; }
        public string Title { get; set; }
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Electronic : IProduct
    {
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class Grocery : IProduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
