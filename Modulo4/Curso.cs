using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo4
{
    //Definición de clase y métodos de mostrar por pantalla para ejercicio 5
    //Cambio a abstract para ejercicio 9
    public abstract class Curso
    {
        private string titulo;
        private double precio;
        private int horas;

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = string.IsNullOrWhiteSpace(value) || value.Length > 100 ? "-----" : value;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value < 0 ? 0 : value;
            }
        }
        public int Horas
        {
            get
            {
                return horas;
            }
            set
            {
                horas = value < 0 || value > 1000 ? 10 : value;
            }
        }
        public Curso(string titulo, double precio, int horas)
        {
            Titulo = titulo;
            Precio = precio;
            Horas = horas;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("----- Información del curso -----\n");
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Precio: " + precio.ToString());
            Console.WriteLine("Horas: " + Horas.ToString());
            Console.WriteLine("Precio calculado: " + CalcularPrecio().ToString());
        }

        //Para ejercicio 9 hay que definirlo como abstracto
        public abstract double CalcularPrecio();
        //public virtual double CalcularPrecio()
        //{
        //    return Precio;
        //}
    }

    //Definición de clase y métodos para ejercicio 6
    //Añadimos particula virtual - override para aprovechar metodo mostrar info 
    public class CursoOnline : Curso
    {
        private string url;
        public string URL
        {
            get
            {
                return url;
            }
            set
            {
                url = string.IsNullOrWhiteSpace(value) ? "----" : value;
            }
        }

        public CursoOnline(string titulo, double precio, int horas, string url) : base(titulo, precio, horas)
        {
            URL = url;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("URL: " + URL);
        }

        public override double CalcularPrecio()
        {
            return Precio;
        }
    }

    //Definición de clase y métodos para ejercicio 7
    //Añadimos particula virtual - override para aprovechar metodo mostrar info y calcular precio
    public class CursoAMedida : Curso
    {
        private string cliente;
        private byte numAlumnos;

        public string Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = string.IsNullOrWhiteSpace(value) ? "-----" : value;
            }
        }

        public byte NumAlumnos
        {
            get
            {
                return numAlumnos;
            }
            set
            {
                if(Horas <= 8)
                {
                    numAlumnos = 20;
                }
                else
                {
                    //numAlumnos = value < 10 ? 10 : value;
                    if(value < 10)
                    {
                        numAlumnos = 10;
                    }
                    else if(value > 100)
                    {
                        numAlumnos = 100;
                    }
                    else
                    {
                        numAlumnos = value;
                    }
                }
            }
        }

        public CursoAMedida(string titulo, double precio, int horas, string cliente, byte numalumnos) : base(titulo, precio, horas)
        {
            Cliente = cliente;
            NumAlumnos = numalumnos;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Cliente: " + Cliente);
            Console.WriteLine("NumAlumnos: " + NumAlumnos.ToString());
        }

        //Implementacion por ejercicio 9 que clase base es abstracta
        public override double CalcularPrecio()
        {
            if (NumAlumnos > 50)
            {
                return 0.6 * Precio;
            }
            else if (NumAlumnos > 25)
            {
                return 0.8 * Precio;
            }
            else
            {
                return Precio;
            }
        }

        /*public override double CalcularPrecio()
        {
            if(NumAlumnos > 50)
            {
                return 0.6 * base.CalcularPrecio();
            }
            else if(NumAlumnos > 25)
            {
                return 0.8 * base.CalcularPrecio();
            }
            else
            {
                return base.CalcularPrecio();
            }
        }*/

        /*//Forzamos redefinición sin usar override
        public new double CalcularPrecio()
        {
            if (NumAlumnos > 50)
            {
                return 0.6 * Precio;
            }
            else if (NumAlumnos > 25)
            {
                return 0.8 * Precio;
            }
            else
            {
                return Precio;
            }
        }
        */
    }
}
