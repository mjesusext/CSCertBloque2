using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Program
    {
        public const int PIXELS_BASE = 1920;
        public const int PIXELS_ALTURA = 1080;

        static void Main(string[] args)
        {
            #region Ejercicios1a7

            //DateTime T1;
            //T1 = DateTime.Now;
            ////Ejercicio1a6();
            //Ejercicio7();
            //Console.WriteLine("Tiempo de ejecución " + DateTime.Now.Subtract(T1).TotalSeconds.ToString());

            #endregion

            //Ejercicio8();
            //Ejercicio10a17();
            Ejercicio18();

            Console.ReadLine();
        }

        public static void Ejercicio1a6()
        {
            Console.WriteLine("----- Ejercicio 1a6: inicio -----\n");
            //Al ser una matriz unidimensional, debemos llevar el conteo.
            //Las posiciones empiezan en 1 - 1, deberemos cuidar los indices del iterador

            int pos_total = 0;
            Pixel[] Pantalla = new Pixel[PIXELS_BASE * PIXELS_ALTURA];

            for (int j = 1; j <= PIXELS_ALTURA; j++)
            {
                for (int i = 1; i <= PIXELS_BASE; i++)
                {
                    Pantalla[pos_total++] = new Pixel(i, j, new Color(0,0,0));
                }
            }

            Console.WriteLine("La posición 801 tiene coordenada X = " + Pantalla[800].x.ToString() + " Y = " + Pantalla[800].y.ToString());
            Console.WriteLine("El color de la posición 801 es: " + Pantalla[800].color.ToString());
            Console.WriteLine("----- Ejercicio 1a6: final -----\n");
        }

        public static void Ejercicio7()
        {
            Console.WriteLine("----- Ejercicio 7: inicio -----\n");
            //Al ser una matriz unidimensional, debemos llevar el conteo.
            //Las posiciones empiezan en 1 - 1, deberemos cuidar los indices del iterador
            Console.WriteLine("Creando matriz");

            int pos_total = 0;
            Pixel[] Pantalla = new Pixel[PIXELS_BASE * PIXELS_ALTURA];

            for (int j = 1; j <= PIXELS_ALTURA; j++)
            {
                for (int i = 1; i <= PIXELS_BASE; i++)
                {
                    Pantalla[pos_total++] = new Pixel(i, j, new Color(0, 0, 0));
                }
            }

            Console.WriteLine("Contatenando ToStrings de las 20000 primeras posiciones");
            DateTime T1 = DateTime.Now;
            
            //string resultado = string.Empty;
            StringBuilder resultadoB = new StringBuilder();

            for (int i = 0; i < 20000; i++)
            {
                //resultado += Pantalla[i].ToString() + "\r\n";
                resultadoB.Append(Pantalla[i].ToString());
                resultadoB.Append("\r\n");
            }

            Console.WriteLine("Tiempo de concatenación en segundos: " + DateTime.Now.Subtract(T1).TotalSeconds.ToString());
            Console.WriteLine("----- Ejercicio 7: final -----\n");
            //Resultados
            //class class string 19,52
            //struct struct string 5,04
            //class class builder 0,08
            //struct struct builder 0,05
        }

        public static void Ejercicio8()
        {
            Usuario[] usuarios = new Usuario[3];
            usuarios[0] = new Usuario("Manuel", TipoUsuario.Lector);
            usuarios[1] = new Usuario("Antonio", TipoUsuario.Lector | TipoUsuario.OperadorInformes);
            usuarios[2] = new Usuario("María", TipoUsuario.Lector | TipoUsuario.OperadorInformes | TipoUsuario.GestorUsuarios | TipoUsuario.Administrador);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Usuario " + i.ToString());
                Console.WriteLine("Nombre: " + usuarios[i].Nombre);
                Console.WriteLine("Es gestor de usuarios: " + EsGestorUsuarios(usuarios[i]).ToString());
                Console.WriteLine("Es administrador: " + EsAdministrador(usuarios[i]).ToString());
            }
        }

        //Ejercicio 9
        public static bool EsGestorUsuarios(Usuario u)
        {
            return u.Tipo.HasFlag(TipoUsuario.GestorUsuarios);
        }

        //Ejercicio9
        public static bool EsAdministrador(Usuario u)
        {
            return u.Tipo.HasFlag(TipoUsuario.Administrador);
        }

        public static void Ejercicio10a17()
        {
            Superman sup1 = new Superman();
            IAvion sup2 = sup1;
            IPajaro sup3 = sup1;

            sup1.Volar();
            sup1.Aletear();

            sup2.Volar();
            //sup2.Aletear(); //Da error porque hemos dicho que apunte a una referencia tratándolo como un tipo. Exactamente la implementación de la interfaz
            sup3.Volar();
            sup3.Aletear();


        }

        public static void Ejercicio18()
        {
            string cadena = "En un lugar de La Mancha de cuyo nombre no quiero acordarme";
            Console.WriteLine(cadena.EstaVacia());
            Console.WriteLine(cadena.Invertir());
            Console.WriteLine(cadena.Left(11));
            Console.WriteLine(cadena.Right(9));
        }
    }
}
