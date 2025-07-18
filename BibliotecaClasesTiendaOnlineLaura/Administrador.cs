using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Administrador : Usuario
    {

        public Administrador(string Nombre, int DNI, int ID_Administrador) : base(Nombre, DNI)
        {

            this.ID_Administrador = ID_Administrador;

        }

        public int ID_Administrador { get; set; }

        public void AgregarStock(Producto producto)
        {
            string input = Console.ReadLine();
            int cantAñadida;
            bool conversion = int.TryParse(input, out cantAñadida);

            while(conversion == false)
            {
                Console.WriteLine("Información incorrecta, ingresela de vuelta:");
                input = Console.ReadLine();
                conversion = int.TryParse(input,out cantAñadida);

            }

            producto.CantidadDisponible = producto.CantidadDisponible + cantAñadida;

        }

        public void AñadirProducto(string NombreProd, double precio, int cant)
        {
            //new Producto(NombreProd, precio, cant);
            Catalogo.ListaProductos.Add(new Producto(NombreProd, precio, cant));



        }

    }
}
