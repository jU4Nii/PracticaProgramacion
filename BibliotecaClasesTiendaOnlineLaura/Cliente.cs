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
        public Cliente(string NombreUsuario, int DNI, int ID_Cliente) : base(NombreUsuario, DNI)
        {

            this.ID_Cliente = ID_Cliente;

            CarritoDeUsuario = new Carrito();

        }

        public int ID_Cliente { get; set; }

        public string Direccion {  get; set; }

        public Carrito CarritoDeUsuario { get; set; }

        public double TotalCompra {  get; set; }

        public void AñadirACarrito(Producto producto, int cantidad)
        {

            
            if (producto.CantidadDisponible >= cantidad)
            {

                CarritoDeUsuario.AñadirObjeto(producto, cantidad);
                TotalCompra += producto.Precio;
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

            Console.WriteLine($"Orden de compra por ${TotalCompra} confirmada. Se adjunta factura de la misma:");

            Console.WriteLine();

            Console.WriteLine("Producto - Precio");

            



        }


    }
}
