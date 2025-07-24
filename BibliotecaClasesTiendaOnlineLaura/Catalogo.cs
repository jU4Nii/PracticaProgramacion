using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Catalogo
    {

        public static List<Producto> ListaProductos = new List<Producto>();

        public static void InicializarCatalogo()
        {
            if (ListaProductos.Count > 0) return;

            ListaProductos.Clear();

            ListaProductos.Add(new Producto("Gorra Nike", 10000, 4));
            ListaProductos.Add(new Producto("Pantalon deportivo Adidas", 13000, 10));
            ListaProductos.Add(new Producto("Campera polar", 100000, 3));
            ListaProductos.Add(new Producto("Pulsera de acero", 5000, 5));
            ListaProductos.Add(new Producto("Boxer", 6000, 10));
            ListaProductos.Add(new Producto("Cadena de acero", 8000, 8));


        }

    }
}
