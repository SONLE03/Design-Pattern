using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class EBooks : OrderProcessor
    {
        protected override void PackageProduct()
        {
            Console.WriteLine("Generating digital access key.");
        }
        protected override void Ship()
        {
            Console.WriteLine("Sending product download link via email.");
        }
    }
}
