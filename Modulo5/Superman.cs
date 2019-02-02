using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Superman : IAvion , IPajaro
    {
        public void Aletear()
        {
            Console.WriteLine("Superman aleteando!");
        }
        public void Volar()
        {
            Console.WriteLine("Superman volando!");
        }

        void IPajaro.Aletear()
        {
            Console.WriteLine("Superman aleteando como un pájaro!");
        }

        void IPajaro.Volar()
        {
            Console.WriteLine("Superman volando como un pájaro!");
        }

        void IAvion.Volar()
        {
            Console.WriteLine("Superman volando como un avión!");
        }
    }
}
