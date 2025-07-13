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

        public void AñadirACarrito(Producto producto, int cantidad)
        {

            if (producto.CantidadDisponible >= cantidad)
            {

                CarritoDeUsuario.AñadirObjeto(producto, cantidad);

            }
            else
            {
                Console.WriteLine($"El producto {producto} no se puede añadir al carrito porque no hay stock de la cantidad solicitada. ({producto.CantidadDisponible} restantes)");
                Console.WriteLine("Pruebe con otra cantidad o espere a que haya stock.");
            }

        }

        public void verCarrito()
        {

            CarritoDeUsuario.MostrarCarrito();

        }

    }
}
