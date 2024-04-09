using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Display
    {
        public void Show(string content)
        {
            Console.WriteLine($"Displaying: {content}");
        }
    }
}
