using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    [Flags]
    public enum TipoUsuario
    {
        Lector = 0, //Valor básico, sino creariamos un Ninguno a parte de Lector
        OperadorInformes = 2,
        GestorUsuarios = 4,
        Administrador = 8 //Tambien se podria hacer 8 + 4 + 2 (tres bits independientes a 1 y englobar lo anterior)
    }

    public class Usuario
    {
        public string Nombre { get; set; }
        public TipoUsuario Tipo { get; set; }

        public Usuario(string nombre, TipoUsuario tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }
    }
}
