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

            //Persona p1 = new Persona("Carlos", "Rodríguez", DateTime.Now);
            //Persona p2 = new Persona("Carlos", "Rodríguez", DateTime.Now);
            //int i1 = 1, i2 = 1;
            //string s1 = "Hola", s2 = "Hola";

            ////Como todos los tipos se usan y son informados en método, lo infiere
            //Console.WriteLine("Comparación de personas: {0}", IgualdadA(p1, p2)); //Clase Persona no implementa comparadores, compara referencias a memoria y son distintas. Dará false
            //Console.WriteLine("Comparación de enteros: {0}", IgualdadA(i1, i2));
            //Console.WriteLine("Comparación de strings: {0}", IgualdadA(s1, s2));

            #endregion

            #region Ejercicio 2

            //Alumno a1 = new Alumno()
            //{
            //    Nombre = "Calos",
            //    Apellidos = "Rodríguez",
            //    FechaNacimiento = DateTime.Now
            //};

            //Profesor p1 = new Profesor()
            //{
            //    Nombre = "Calos",
            //    Apellidos = "Rodríguez",
            //    FechaNacimiento = DateTime.Now
            //};

            //Conserje c1 = new Conserje()
            //{
            //    Nombre = "Calos",
            //    Apellidos = "Rodríguez",
            //    FechaNacimiento = DateTime.Now
            //};

            //Console.WriteLine("Comparación de profesor y conserje con equals: {0}", IgualdadB<IFuncionario>(p1, c1)); //Clase Persona no implementa comparadores, compara referencias a memoria y son distintas. Dará false
            //Console.WriteLine("Comparación de profesor y conserje aprovechando info de restricción: {0}", IgualdadC<IFuncionario>(p1, c1));

            #endregion

            #region Ejercicio 3
            Profesor p1 = new Profesor()
            {
                Nombre = "Calos",
                Apellidos = "Rodríguez",
                FechaNacimiento = DateTime.Now
            };

            Conserje c1 = new Conserje()
            {
                Nombre = "Calos",
                Apellidos = "Rodríguez",
                FechaNacimiento = DateTime.Now
            };

            Comparador<IFuncionario> comp = new Comparador<IFuncionario>();
            comp.itemA = p1;
            comp.itemB = c1;

            Console.WriteLine("Comparación de profesor y conserje aprovechando clase: {0}", comp.Igualdad());
            #endregion

            Console.ReadLine();
        }

        //Ejercicio 1
        public static bool IgualdadA<T>(T inputA, T inputB)
        {
            return inputA.Equals(inputB);
        }

        //Ejercicio 2A
        public static bool IgualdadB<T>(T inputA, T inputB)
            where T : IFuncionario
        {
            return inputA.Equals(inputB);
        }

        //Ejercicio 2B
        public static bool IgualdadC<T>(T inputA, T inputB)
            where T : IFuncionario
        {
            return inputA.Nombre == inputB.Nombre &&
                   inputA.Apellidos == inputB.Apellidos;
        }
    }
}
