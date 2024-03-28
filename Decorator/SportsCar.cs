﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {

        }
        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of Sports Car.");
        }
    }
}
