using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4_2
{
    class SquareFigure : Figure
    {
        public int Side { get; set; }
        public override double Perimetr()
        {
            return Side * 4;
        }

        public override double Square()
        {
            return (double)Side * (double)Side;
        }

        public override string ToString()
        {
            return "Square with Side " + Side;
        }
    }
}
