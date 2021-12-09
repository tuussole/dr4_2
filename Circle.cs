using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_2
{
    class Circle : Figure
    {
        public int Radius { get; set; }

        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle with Radius " + Radius;
        }
    }
}
