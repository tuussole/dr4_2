using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_2
{
    class Rectangle : Figure
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public override double Perimetr()
        {
            return 2 * (Side1 + Side2);
        }

        public override double Square()
        {
            return Side1 * Side2;
        }

        public override string ToString()
        {
            return "Rectangle with Sides  " + Side1 + " and " + Side2;
        }
    }
}
