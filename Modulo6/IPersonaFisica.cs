using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo6
{
    //Ejercicio 7
    public interface IPersonaFisica<Tprecision>
        where Tprecision : struct
    {
        string Nombre { get; set; }
        Tprecision Peso { get; set; }
        Tprecision Altura { get; set; }

        void MostrarDatosFisicos();
    }
}
