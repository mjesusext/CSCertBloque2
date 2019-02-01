using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Program
    {
        public const int PIXELS_BASE = 800;
        public const int PIXELS_ALTURA = 600;

        static void Main(string[] args)
        {
            Ejercicio1();
            Console.ReadLine();
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("----- Ejercicio 1: inicio -----\n");
            //Al ser una matriz unidimensional, debemos llevar el conteo.
            //Las posiciones empiezan en 1 - 1, deberemos cuidar los indices del iterador

            int pos_total = 0;
            Pixel[] Pantalla1 = new Pixel[PIXELS_BASE * PIXELS_ALTURA];

            for (int j = 1; j <= PIXELS_ALTURA; j++)
            {
                for (int i = 1; i <= PIXELS_BASE; i++)
                {
                    Pantalla1[pos_total++] = new Pixel(i, j, new Color());
                }
            }

            Console.WriteLine("La posición 801 tiene coordenada X = " + Pantalla1[800].x.ToString() + " Y = " + Pantalla1[800].y.ToString());
            Console.WriteLine("----- Ejercicio 1: final -----\n");
        }
    }
}
