using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public abstract class Usuario
    {

        public Usuario(string Nombre, int DNI)
        {

            this.Nombre = Nombre;

            this.DNI = DNI;
        }

        public string Nombre { get; set; }

        public int DNI { get; set; }

    }
}
