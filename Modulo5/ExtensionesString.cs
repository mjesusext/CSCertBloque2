using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    public static class ExtensionesString
    {
        public static string Invertir(this string str)
        {
            string resultado = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                resultado += str[i];
            }

            return resultado;
        }

        public static bool EstaVacia(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string Right(this string str, int pos)
        {
            return str.Substring(str.Length - pos, pos);
        }

        public static string Left(this string str, int pos)
        {
            return str.Substring(0, pos);
        }
    }
}
