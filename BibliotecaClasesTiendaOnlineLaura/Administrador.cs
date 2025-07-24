using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTiendaOnlineLaura
{
    public class Administrador : Usuario
    {

        public Administrador(string Nombre, int DNI) : base(Nombre, DNI)
        {

            this.ID_Administrador = contadorIDAdmin;
            contadorIDAdmin++;

        }

        private static int contadorIDAdmin = 1;
        public int ID_Administrador { get; private set; }

        public void AgregarStock(int numProducto)
        {
            Console.WriteLine("Ingrese la cantidad que desea agregar:");
            string input = Console.ReadLine();
            int cantAñadida;
            bool conversion = int.TryParse(input, out cantAñadida);

            while(conversion == false)
            {
                Console.WriteLine("Información incorrecta, ingresela de vuelta:");
                input = Console.ReadLine();
                conversion = int.TryParse(input,out cantAñadida);

            }

            Catalogo.ListaProductos[numProducto-1].CantidadDisponible = Catalogo.ListaProductos[numProducto-1].CantidadDisponible + cantAñadida;

        }

        public void AñadirProducto(string NombreProd, double precio, int cant)
        {
            //new Producto(NombreProd, precio, cant);
            Catalogo.ListaProductos.Add(new Producto(NombreProd, precio, cant));



        }

    }
}
