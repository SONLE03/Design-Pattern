using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class Circle
    {
        public string Color { get; set; }
        private readonly int _xCor = 10;
        private readonly int _yCor = 20;
        private readonly int _radius = 30;

        public void Draw()
        {
            Console.WriteLine($"Circle: Draw() [Color: {Color}, X Cor: {_xCor}, Y Cor: {_yCor}, Radius: {_radius}]");
        }
    }
}
