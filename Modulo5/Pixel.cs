using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    public class Pixel
    {
        public int x { get; set; }
        public int y { get; set; }
        public Color color { get; set; }

        public Pixel(int X, int Y, Color Color)
        {
            x = X;
            y = Y;
            color = Color;
        }

        //Modificación ejercicio 7
        public override string ToString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ") - " + color.ToString();
        }
    }
}
