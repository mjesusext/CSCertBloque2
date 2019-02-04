using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    public class Color
    {
        public byte r { get; set; }
        public byte g { get; set; }
        public byte b { get; set; }

        public Color(byte R, byte G, byte B)
        {
            r = R;
            g = G;
            b = B;
        }

        //Modificación ejercicio 6
        public override string ToString()
        {
            return "rgb(" + r.ToString() + "," + g.ToString() + "," + b.ToString() + ")";
        }
    }
}
