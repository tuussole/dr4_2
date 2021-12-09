using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_2
{
    class Triangle : Figure
    {
        public int Side { get; set; }
        public override double Perimetr()
        {
            return Side * 3;
        }

        public override double Square()
        {
            return Side * Math.Sqrt(3) / 2;
        }

        public override string ToString()
        {
            return "Triangle with Side " + Side;
        }
    }
}
