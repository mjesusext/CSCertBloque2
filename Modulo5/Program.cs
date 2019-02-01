using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Program
    {
        public const int PIXELS_BASE = 600;
        public const int PIXELS_ALTURA = 800;

        static void Main(string[] args)
        {
            Ejercicio1();
            Console.ReadLine();
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("----- Ejercicio 1: inicio -----\n");

            Pixel[] Pantalla1 = new Pixel[PIXELS_BASE * PIXELS_ALTURA];

            for (int j = 0; j < PIXELS_ALTURA; j++)
            {
                for (int i = 0; i < PIXELS_BASE; i++)
                {
                    Pantalla1[i + j] = new Pixel(i, j, new Color());
                }
            }

            Console.WriteLine("La posición 801 tiene coordenada X = " + Pantalla1[800].x.ToString() + " Y = " + Pantalla1[800].y.ToString());
            Console.WriteLine("----- Ejercicio 1: final -----\n");
        }
    }
}
