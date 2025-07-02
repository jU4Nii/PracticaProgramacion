using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Producto
    {

        public Producto(string Nombre, double Precio, int CantidadDisponible)
        {
            this.Nombre = Nombre;

            this.Precio = Precio;

            this.CantidadDisponible = CantidadDisponible;
        }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int CantidadDisponible { get; set; }

    }
}
