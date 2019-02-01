using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Pixel
    {
        public int x { get; set; }
        public int y { get; set; }
        public Color color { get; set; }

        public Pixel()
        {
            x = 0;
            y = 0;
            color = new Color();
        }

        public Pixel(int X, int Y, Color Color)
        {
            x = X;
            y = Y;
        }
    }
}
