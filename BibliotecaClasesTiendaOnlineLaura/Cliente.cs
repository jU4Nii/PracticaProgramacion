using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Cliente : Usuario
    {
        public Cliente(string NombreUsuario, int DNI, int ID_Cliente) : base(NombreUsuario, DNI)
        {

            this.ID_Cliente = ID_Cliente;

        }

        public int ID_Cliente { get; set; }

        public string Direccion {  get; set; }

        public List<Producto> Carrito { get; set; }

    }
}
