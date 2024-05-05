using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Book : OrderProcessor
    {
        protected override void PackageProduct()
        {
            Console.WriteLine("Packaging the book securely (adding protective padding)");
        }
        protected override void Ship()
        {
            Console.WriteLine("Shipping the book via standard mail.");
        }
    }
}
