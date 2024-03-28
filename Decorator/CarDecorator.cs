using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual void Assemble()
        {
            this.car.Assemble();
        }
    }
}
