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

        public void AñadirACarrito(int numProd)
        {
            for (int i = 0; i < Catalogo.ListaProductos.Count; i++)
            {

                if (Catalogo.ListaProductos[numProd - 1].CantidadDisponible > 0)
                {

                    CarritoDeUsuario.AñadirObjeto(Catalogo.ListaProductos[numProd - 1]);
                    SubTotalCompra += Catalogo.ListaProductos[numProd - 1].Precio;

                }
                else
                {
                    Console.WriteLine($"El producto {Catalogo.ListaProductos[numProd - 1]} no se puede añadir al carrito porque no hay stock");

                }

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
