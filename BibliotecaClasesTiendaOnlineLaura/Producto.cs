using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Producto
    {

        public Producto(string NombreProducto, double Precio, int CantidadDisponible)
        {
            this.NombreProducto = NombreProducto;

            this.Precio = Precio;

            this.CantidadDisponible = CantidadDisponible;
        }

        public string NombreProducto { get; set; }

        public double Precio { get; set; }

        public int CantidadDisponible { get; set; }

    }
}
