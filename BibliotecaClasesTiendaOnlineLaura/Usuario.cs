using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public abstract class Usuario
    {

        public Usuario(string NombreUsuario, int DNI)
        {

            this.NombreUsuario = NombreUsuario;
            this.DNI = DNI;
        }

        public string NombreUsuario { get; set; }

        public int DNI { get; set; }

    }
}
