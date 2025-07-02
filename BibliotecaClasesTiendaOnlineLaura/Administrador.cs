using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Administrador : Usuario
    {

        public Administrador(string Nombre, int DNI, int ID_Administrador) : base(Nombre, DNI)
        {

            this.ID_Administrador = ID_Administrador;

        }

        public int ID_Administrador { get; set; }


    }
}
