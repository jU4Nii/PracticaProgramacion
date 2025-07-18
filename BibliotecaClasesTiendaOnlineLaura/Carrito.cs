using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Carrito
    {

        public Carrito()
        {
            ListaCarritoUsuario = new List<Producto>();

            CantidadesProductosDelCarrito = new List<int>();
        }


        public List<Producto> ListaCarritoUsuario {  get; set; } 

        public List<int> CantidadesProductosDelCarrito {  get; set; }

        public void AñadirObjeto(Producto producto, int Cantidad)
        {
            ListaCarritoUsuario.Add(producto);
            CantidadesProductosDelCarrito.Add(Cantidad);

        }

        public void MostrarCarrito()
        {
            Console.WriteLine("Producto - Cantidad");

            for (int i = 0; i < ListaCarritoUsuario.Count; i++)
            {
                Console.WriteLine($"{ListaCarritoUsuario[i].NombreProducto} - {CantidadesProductosDelCarrito[i]}");
            }


        }

        public void GenerarFactura()
        {

            foreach(Producto p in ListaCarritoUsuario)
            {

                Console.WriteLine($"{p.NombreProducto} - ${p.Precio}");

            }


        }

    }
}
