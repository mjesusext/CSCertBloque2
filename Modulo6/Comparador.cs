using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    //Añadir segundo parámetro de tipo genérico. Ejercicio 5
    public class Comparador<T,U>
        where T : IFuncionario 
    {
        public Comparador()
        {
        }

        public Comparador(U valorA, U valorB)
        {
            valA = valorA;
            valB = valorB;
        }

        public T itemA { get; set; } = default(T);
        public T itemB { get; set; } = default(T);

        public U valA { get; set; } = default(U);
        public U valB { get; set; } = default(U);

        public bool Igualdad()
        {
            //Es un tipo referencia al forzar el where contra una interfaz. Su default es nulo.
            if (itemA == null || itemB == null)
            {
                return false;
            }

            return itemA.Nombre == itemB.Nombre &&
                   itemA.Apellidos == itemB.Apellidos;
        }

        public string UnirValoresEj4<Tinput>(Tinput valorA, Tinput valorB)
        {
            //Validamos si es del tipo de la clase, strings, numeros o fechas
            if (valorA is T)
            {
                return ((IFuncionario)valorA).Nombre +
                       ((IFuncionario)valorA).Apellidos +
                       ((IFuncionario)valorB).Nombre +
                       ((IFuncionario)valorB).Apellidos;
            }
            else if (valorA is string)
            {
                return valorA as string + valorB as string;

            }
            else if (valorA is int)
            {
                return (Convert.ToInt32(valorA) + Convert.ToInt32(valorB)).ToString();
            }
            else if (valorA is DateTime)
            {
                return (Convert.ToDateTime(valorA).Subtract(Convert.ToDateTime(valorB))).ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public string UnirValoresEj5()
        {
            //Validamos si es del tipo de la clase, strings, numeros o fechas
            if(valA is T)
            {
                return ((IFuncionario)valA).Nombre +
                       ((IFuncionario)valA).Apellidos +
                       ((IFuncionario)valB).Nombre +
                       ((IFuncionario)valB).Apellidos;
            }
            else if(valA is string)
            {
                return valA as string + valB as string;
                       
            }
            else if(valA is int)
            {
                return (Convert.ToInt32(valA) + Convert.ToInt32(valB)).ToString();
            }
            else if(valA is DateTime)
            {
                return (Convert.ToDateTime(valA).Subtract(Convert.ToDateTime(valB))).ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
