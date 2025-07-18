using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Cliente : Usuario
    {
        public Cliente(string NombreUsuario, int DNI) : base(NombreUsuario, DNI)
        {
            this.ID_Cliente = contadorID;
            contadorID++;

            CarritoDeUsuario = new Carrito();

        }

        private static int contadorID = 1;

        public int ID_Cliente { get; private set; }

        public Carrito CarritoDeUsuario { get; set; }

        public double SubTotalCompra {  get; set; }

        public void AñadirACarrito(Producto producto, int cantidad)
        {

            
            if (producto.CantidadDisponible >= cantidad)
            {

                CarritoDeUsuario.AñadirObjeto(producto, cantidad);
                SubTotalCompra += producto.Precio;
            }
            else
            {
                Console.WriteLine($"El producto {producto} no se puede añadir al carrito porque no hay stock de la cantidad solicitada. ({producto.CantidadDisponible} restantes)");
                Console.WriteLine("Pruebe con otra cantidad o espere a que haya stock.");
            }

        }

        public void VerCarrito()
        {

            CarritoDeUsuario.MostrarCarrito();

        }
        
        public void VerProductos()
        {

            Console.WriteLine("Catálogo de productos:");

            foreach(Producto producto in Catalogo.ListaProductos)
            {

                Console.WriteLine($"{producto.NombreProducto} - {producto.CantidadDisponible} unidades");

            }

        }

        public void ConfirmarCompra()   
        {

            Console.WriteLine($"Orden de compra confirmada. Se adjunta factura de la misma:");

            Console.WriteLine();

            Console.WriteLine("Producto - Precio");

            CarritoDeUsuario.GenerarFactura();

            Console.WriteLine($"SubTotal: ${SubTotalCompra}");

            double iva = SubTotalCompra * 0.21;

            Console.WriteLine($"Impuestos: ${iva}");

            Console.WriteLine($"Total: ${SubTotalCompra + iva}");


        }


    }
}
