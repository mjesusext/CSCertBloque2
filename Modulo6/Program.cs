using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            Persona a1 = new Persona("Carlos", "Rodríguez", DateTime.Now);
            Persona a2 = new Persona("Carlos", "Rodríguez", DateTime.Now);
            int i1 = 1, i2 = 1;
            string s1 = "Hola", s2 = "Hola";
            
            //Como todos los tipos se usan y son informados en método, lo infiere
            Console.WriteLine("Comparación de personas: {0}", Igualdad(a1, a2));
            Console.WriteLine("Comparación de enteros: {0}", Igualdad(i1, i2));
            Console.WriteLine("Comparación de strings: {0}", Igualdad(s1, s2));
            #endregion

            Console.ReadLine();
        }

        //Ejercicio 1
        public static bool Igualdad<T>(T inputA, T inputB)
        {
            return inputA.Equals(inputB);
        }
    }
}
