using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteCar : ICar
    {
        public void Assemble()
        {
            Console.WriteLine("Concrete Car.");
        }
    }
}
