using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    public class Comparador<T>
        where T : IFuncionario
    {
        public Comparador()
        {
        }

        public T itemA { get; set; }
        public T itemB { get; set; }

        public bool Igualdad()
        {
            if (itemA == null || itemB == null)
            {
                return false;
            }

            return itemA.Nombre == itemB.Nombre &&
                   itemA.Apellidos == itemB.Apellidos;
        }

        public string UnirValores<Tinput>(Tinput valorA, Tinput valorB)
        {
            //Validamos si es del tipo de la clase, strings, numeros o fechas
            

            return string.Empty;
        }
    }
}
