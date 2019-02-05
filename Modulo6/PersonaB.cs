using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    //Ejercicio 7
    public class PersonaB<Tprecision> : IPersonaFisica<Tprecision>
        where Tprecision : struct
    {
        public string Nombre { get; set; }
        public Tprecision Peso { get; set; }
        public Tprecision Altura { get; set; }

        public void MostrarDatosFisicos()
        {
            Console.WriteLine(Nombre + " pesa " + Peso.ToString() + " kilos y mide " + Altura.ToString() + " metros.");
        }
    }
}
