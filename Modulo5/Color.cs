using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Color
    {
        public byte r { get; set; }
        public byte g { get; set; }
        public byte b { get; set; }

        public Color()
        {
            r = 0;
            g = 0;
            b = 0;
        }

        public Color(byte R, byte G, byte B)
        {
            r = R;
            g = G;
            b = B;
        }
    }
}
