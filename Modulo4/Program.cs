using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1 y 2
            //int[] Test1Ej1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] Test2Ej1 = { };
            //int[] Test3Ej1 = { 2147483646, 2147483647 };
            //long resTest3Ej1;
            //resTest3Ej1 = Sumar(Test1Ej1);
            //resTest3Ej1 = Sumar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            //Console.WriteLine("El resultado de la suma es " + resTest3Ej1.ToString());
            #endregion

            #region Ejercicio 3
            //string mensaje1 = "Mensaje 1";
            //string mensaje2 = "Mensaje 2";

            //Intercambiar(ref mensaje1, ref mensaje2);

            //Console.WriteLine("Mensaje 1 contiene: " + mensaje1);
            //Console.WriteLine("Mensaje 2 contiene: " + mensaje2);
            #endregion

            #region Ejercicio 4
            //int Test1_BaseEj4 = 2, Test1_ExpEj4 = 10;
            //long Test1_ResEj4 = Potencia(Test1_BaseEj4, Test1_ExpEj4);

            //Console.WriteLine("El resultado de " + Test1_BaseEj4.ToString() + " elevado a " + Test1_ExpEj4.ToString() + " es " + Test1_ResEj4.ToString());
            #endregion

            #region Ejercicio 5
            //Curso curso = new Curso(null, -3D, 150000);
            //curso.MostrarInfo();
            #endregion

            #region Ejercicio 6
            //CursoOnline cursoOnline = new CursoOnline(null, -3D, 150000, "https://www.google.es");
            //cursoOnline.MostrarInfo();
            #endregion

            #region Ejercicio 7

            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// Ejercicio 1 
        /// Suma de valores de matriz. Versión 1 y 2 (arreglando overflow de suma)
        /// </summary>
        /// <param name="sumandos"></param>
        /// <returns></returns>
        public static long Sumar(int[] sumandos)
        {
            Console.WriteLine("----- Ejercicio 1 (sumar V2): inicio -----\n");
            //Se podria resolver con Sum de la libreria LINQ o por bucle que itere matriz

            //En V1 la variable era entera
            long resultado = 0; 

            for (int i = 0; i < sumandos.Length; i++)
            {
                resultado += sumandos[i];
            }

            Console.WriteLine("----- Ejercicio 1 (sumar V2): final -----\n");
            return resultado;
        }

        /// <summary>
        /// Ejercicio 2
        /// Suma de valores de matriz, Versión con params
        /// Se ha añadido el primer sumando (opcional) por separado para que la firma Suma(matriz int) no sea exacta y permita sobrecarga.
        /// Con esto se consigue exactamente la misma funcionalidad pero con múltiples parámetros de 0 a N
        /// </summary>
        /// <param name="primer_sumando">Primer elemento de la suma. Obligatorio</param>
        /// <param name="resto_sumandos"></param>
        /// <returns></returns>
        public static long Sumar(int primer_sumando = 0, params int[] resto_sumandos)
        {
            Console.WriteLine("----- Ejercicio 2: inicio -----\n");
            //Se podria resolver con Sum de la libreria LINQ o por bucle que itere matriz

            //En V1 la variable era entera
            long resultado = primer_sumando;

            for (int i = 0; i < resto_sumandos.Length; i++)
            {
                resultado += resto_sumandos[i];
            }

            Console.WriteLine("----- Ejercicio 2: final -----\n");
            return resultado;
        }

        /// <summary>
        /// Ejercicio 3.
        /// Función para intercambiar valores a las variables. 
        /// Forzamos ref incluso en string para evitar que la immutabilidad de string rompa el intercambio de punteros en el paso por referencia.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public static void Intercambiar(ref string A, ref string B)
        {
            Console.WriteLine("----- Ejercicio 3: inicio -----\n");
            string tmp_value = A;
            A = B;
            B = tmp_value;
            Console.WriteLine("----- Ejercicio 3: final -----\n");
        }

        /// <summary>
        /// Ejercicio 4.
        /// Calculo de potencia de numero entero de forma recursiva. Cuidamos overflow con tipo grande (long)
        /// </summary>
        /// <param name="num"></param>
        /// <param name="exponente"></param>
        /// <returns></returns>
        public static long Potencia(int num, int exponente)
        {
            if(exponente == 0)
            {
                Console.WriteLine("----- Ejercicio 4: exponente 0 -----\n");
                return num;
            }
            else
            {
                Console.WriteLine("----- Ejercicio 4: exponente " + exponente.ToString() + " -----");
                return num * Potencia(num, exponente - 1);
            }
        }
    }
}
