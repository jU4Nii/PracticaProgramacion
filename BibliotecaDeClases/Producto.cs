using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Producto
    {

        public Producto(string Nombre, int Precio)
        {
            this.Nombre = Nombre;

            this.Precio = Precio;


        }

        public string Nombre { get; set; }

        public double Precio { get; set; }

    }
}
