using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Modulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1();
            Ejercicio2();

            Console.ReadLine();
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("----- Ejercicio 1: inicio -----");

            bool okInput = true;
            int maxVal, minVal;
            double avgVal;
            ArrayList arrlist = new ArrayList();

            Console.WriteLine("Introduzca números mayores o iguales a cero. Si introduce valor negativo se procede al cálculo del valor máximo, mínimo, media y cantidad de elementos introducidos");

            while (true)
            {
                int inputNum;
                Console.Write("Introduzca valor: ");
                okInput = int.TryParse(Console.ReadLine(), out inputNum);

                if (okInput)
                {
                    if(inputNum < 0)
                    {
                        break;
                    }

                    arrlist.Add(inputNum);
                }
                else
                {
                    Console.WriteLine("Valor de tipo no entero. Reinténtelo");
                }
            }

            maxVal = (int)arrlist[0];
            minVal = (int)arrlist[0];
            avgVal = 0D;

            for(int i = 1; i < arrlist.Count; i++)
            {
                int tmp_val = (int)arrlist[i];

                maxVal = tmp_val > maxVal ? tmp_val : maxVal;
                minVal = tmp_val < minVal ? tmp_val : minVal;
                avgVal += tmp_val;
            }

            avgVal /= arrlist.Count;

            Console.WriteLine("Valor mínimo: " + minVal);
            Console.WriteLine("Valor máximo: " + maxVal);
            Console.WriteLine("Valor medio: " + avgVal);
            Console.WriteLine("----- Ejercicio 1: final -----");
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("----- Ejercicio 2: inicio -----");

            bool okInput = true;
            int pos = 1, maxLen = 0, minLen = 0;
            double avgLen = 0D;
            Hashtable hashTbl = new Hashtable();

            Console.WriteLine("Introduzca nombres de usuario. Cuando se introduzca valor en blanco se parará de añadir nombres");

            while (okInput)
            {
                string strInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(strInput))
                {
                    break;
                }
                else
                {
                    hashTbl.Add(pos++, strInput);
                }
            }

            foreach (DictionaryEntry item in hashTbl)
            {
                string tmp_val = (string)item.Value;
                maxLen = tmp_val.Length > maxLen ? tmp_val.Length : maxLen;
                minLen = tmp_val.Length < minLen ? tmp_val.Length : minLen;
                avgLen += tmp_val.Length;
            }

            avgLen /= hashTbl.Count;

            Console.WriteLine("Longitud nombre más largo: " + maxLen);
            Console.WriteLine("Longitud nombre más corto: " + minLen);
            Console.WriteLine("Cantidad nombres: " + hashTbl.Count);

            while (true)
            {
                Console.WriteLine("Introduzca posición que desea recuperar (en mayuscuylas). En caso de querer finalizar, introduzca 0");

                int inputNum;
                okInput = int.TryParse(Console.ReadLine(), out inputNum);

                if (okInput)
                {
                    if (inputNum == 0)
                    {
                        break;
                    }
                    else if(inputNum < 0)
                    {
                        Console.WriteLine("Valor introducido no es positivo. Reinténtelo");
                    }
                    else
                    {
                        string temp_val = ((string)hashTbl[inputNum]).ToUpper();
                        string temp_long = string.Empty;
                        
                        if(temp_val.Length > avgLen)
                        {
                            temp_long = "superior";
                        }
                        else if(temp_val.Length < avgLen)
                        {
                            temp_long = "inferior";
                        }
                        else
                        {
                            temp_long = "igual";
                        }
                        
                        Console.WriteLine("Valor recuperado: " + temp_val);
                        Console.WriteLine("Longitud respecto media: " + temp_long);
                    }
                }
                else
                {
                    Console.WriteLine("Valor introducido no numérico. Reinténtelo");
                }

            }

            Console.WriteLine("----- Ejercicio 2: final -----");
        }
    }
}
