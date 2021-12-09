using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateFigure(Figure figure)
        {
            var square = figure.Square();
            var perimeter = figure.Perimetr();

            MessageBox.Show(figure.ToString() + ". Perimeter " + perimeter + ", Square " + square);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var figure = new Triangle { Side = 3 };
            CalculateFigure(figure);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var figure = new Circle { Radius = 3 };
            CalculateFigure(figure);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var figure = new Rectangle { Side1 = 3, Side2 = 4 };
            CalculateFigure(figure);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var figure = new SquareFigure { Side = 3 };
            CalculateFigure(figure);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var figure = new Romb { Side = 3, Height = 4 };
            CalculateFigure(figure);
        }
    }
}
