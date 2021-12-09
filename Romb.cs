using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_2
{
    class Romb : Figure
    {
        public int Side { get; set; }
        public int Height { get; set; }

        public override double Perimetr()
        {
            return Side * 4;
        }

        public override double Square()
        {
            return Height * Side;
        }

        public override string ToString()
        {
            return "Romb with Side " + Side + " and Height " + Height;
        }
    }
}
