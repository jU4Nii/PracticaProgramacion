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
            for (int i = 0; i < CarritoDeUsuario.ListaCarritoUsuario.Count; i++)
            {
                for (int j = 0; j < Catalogo.ListaProductos.Count; j++)
                {
                    if (CarritoDeUsuario.ListaCarritoUsuario[i].NombreProducto == Catalogo.ListaProductos[j].NombreProducto)
                    {

                        Catalogo.ListaProductos[j].CantidadDisponible -= 1;

                    }
                }
            }
            Console.WriteLine($"Orden de compra confirmada. Se adjunta factura de la misma:");

            Console.WriteLine();

            Console.WriteLine("Producto - Precio");

            CarritoDeUsuario.GenerarFactura();

            Console.WriteLine($"SubTotal: ${SubTotalCompra}");

            double iva = SubTotalCompra * 0.21;

            Console.WriteLine($"Impuestos: ${iva}");

            double totalCompra = SubTotalCompra + iva;
        
            Console.WriteLine($"Total: ${totalCompra}");

            Factura factura = new Factura(CarritoDeUsuario.ListaCarritoUsuario, SubTotalCompra, iva, totalCompra);

            Console.WriteLine(" ");

            Console.WriteLine("Establezca una dirección para realizar el envio.");
            Console.WriteLine("Calle y número:");
            string direc = Console.ReadLine();
            Envio envio = new Envio(direc);
            Console.WriteLine($"¡Dirección establecida con éxito! El envio se encuentra {envio.EstadoEnvio}.");
            Console.WriteLine("¡Gracias por su compra!");
            

            SubTotalCompra = 0;

            CarritoDeUsuario.ListaCarritoUsuario.Clear();


        }



    }
}
